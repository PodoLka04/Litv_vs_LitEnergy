using UnityEngine;

public class Spinning : MonoBehaviour
{
    public float rotationSpeed = 100f; // Скорость вращения в градусах за секунду

    void Update()
    {
        // Вращаем объект вокруг оси Z
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}
