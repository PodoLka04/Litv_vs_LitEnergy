using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1f;          // Скорость движения
    [SerializeField] private Transform leftBound;       // Левая граница
    [SerializeField] private Transform rightBound;      // Правая граница
    [SerializeField] private Transform topBound;        // Верхняя граница
    [SerializeField] private Transform bottomBound;     // Нижняя граница

    private Vector3 targetPosition;  // Целевая позиция для движения

    void Start()
    {
        // Сразу задаем случайную целевую позицию при старте
        SetRandomTargetPosition();
    }

    void Update()
    {
        // Двигаем объект к целевой позиции
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Если объект достиг цели, задаём новую случайную целевую позицию
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            SetRandomTargetPosition();
        }
    }

    // Задаём новую случайную целевую позицию в пределах границ
    void SetRandomTargetPosition()
    {
        float randomX = Random.Range(leftBound.position.x, rightBound.position.x);  // Случайная позиция по X
        float randomY = Random.Range(bottomBound.position.y, topBound.position.y);  // Случайная позиция по Y
        float randomZ = Random.Range(bottomBound.position.z, topBound.position.z);  // Случайная позиция по Z

        targetPosition = new Vector3(randomX, randomY, randomZ);
    }
}
