using UnityEngine;

public class MoveInCircle : MonoBehaviour
{
    [SerializeField] private float radius = 5f;         // Радиус окружности
    [SerializeField] private float speed = 1f;          // Скорость движения по окружности
    [SerializeField] private Vector3 center = Vector3.zero; // Центр окружности
    [SerializeField] private float verticalAmplitude = 2f;  // Амплитуда вертикального движения
    [SerializeField] private float verticalSpeed = 0.5f;    // Скорость вертикального движения

    // Ссылки на объекты-рамки (границы)
    [SerializeField] private Transform leftBound;   // Левая граница
    [SerializeField] private Transform rightBound;  // Правая граница
    [SerializeField] private Transform topBound;    // Верхняя граница
    [SerializeField] private Transform bottomBound; // Нижняя граница

    private float angle; // Текущий угол движения

    void Update()
    {
        // Увеличиваем угол на основе времени и скорости
        angle += speed * Time.deltaTime;

        // Вычисляем новую позицию объекта по X и Z (движение по кругу)
        float x = Mathf.Cos(angle) * radius + center.x;
        float z = Mathf.Sin(angle) * radius + center.z;

        // Добавляем вертикальное движение по синусоиде
        float y = Mathf.Sin(Time.time * verticalSpeed) * verticalAmplitude + center.y;

        // Ограничиваем позицию с использованием границ-объектов
        x = Mathf.Clamp(x, leftBound.position.x, rightBound.position.x);  // Ограничение по X
        y = Mathf.Clamp(y, bottomBound.position.y, topBound.position.y);  // Ограничение по Y
        z = Mathf.Clamp(z, bottomBound.position.z, topBound.position.z);  // Ограничение по Z

        // Обновляем позицию объекта с учетом ограничений
        transform.position = new Vector3(x, y, z);
    }
}
