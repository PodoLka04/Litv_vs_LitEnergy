using System.Collections;
using UnityEngine;

public class Povorot_cools : MonoBehaviour
{
    public float rotationAngle = 45f; // Максимальный угол поворота
    public float rotationDuration = 2f; // Время одного полного поворота от угла до угла
    public float delayAtEdge = 0.5f; // Задержка в крайних точках

    private bool rotatingClockwise = true; // Направление вращения
    private float currentAngle = 0f; // Текущий угол поворота
    private float timePassed = 0f; // Время, прошедшее с начала вращения в одну сторону
    private bool isReversing = false; // Флаг для проверки задержки

    void Update()
    {
        if (!isReversing)
        {
            RotateObject();
        }
    }

    // Метод вращения объекта с плавным ускорением и замедлением
    void RotateObject()
    {
        // Увеличиваем таймер, отсчитывая время от начала вращения в одну сторону
        timePassed += Time.deltaTime;

        // Нормализуем время в диапазон [0, 1], для полного цикла
        float normalizedTime = timePassed / rotationDuration;

        // Вычисляем плавное изменение угла через синусоидальную функцию для плавности
        float smoothStep = Mathf.Sin(normalizedTime * Mathf.PI); // Создаём плавный ускорение/замедление через синус

        // Вычисляем текущий угол с учётом направления
        float targetAngle = rotatingClockwise ? rotationAngle : -rotationAngle;
        currentAngle = Mathf.Lerp(0f, targetAngle, smoothStep);

        // Поворачиваем объект
        transform.rotation = Quaternion.Euler(0f, 0f, currentAngle);

        // Если полный цикл завершён (нормализованное время стало 1)
        if (normalizedTime >= 1f)
        {
            timePassed = 0f; // Сброс времени
            StartCoroutine(PauseAndReverse()); // Запускаем задержку и разворот
        }
    }

    // Корутин для замедления и смены направления
    IEnumerator PauseAndReverse()
    {
        isReversing = true;

        // Задержка на крайних углах
        yield return new WaitForSeconds(delayAtEdge);

        // Смена направления вращения
        rotatingClockwise = !rotatingClockwise;

        isReversing = false;
    }
}
