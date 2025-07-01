using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulsirovanie : MonoBehaviour
{
    public float scaleSpeed = 1f; // Скорость изменения масштаба
    public Vector3 minScale = new Vector3(1f, 1f, 1f); // Минимальный масштаб
    public Vector3 maxScale = new Vector3(3f, 3f, 3f); // Максимальный масштаб

    private bool increasing = true; // Флаг для определения направления изменения масштаба

    void Update()
    {
        // Изменение масштаба в зависимости от флага
        if (increasing)
        {
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
            if (transform.localScale.x >= maxScale.x)
            {
                increasing = false;
            }
        }
        else
        {
            transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
            if (transform.localScale.x <= minScale.x)
            {
                increasing = true;
            }
        }

        // Ограничение масштаба
        transform.localScale = new Vector3(
            Mathf.Clamp(transform.localScale.x, minScale.x, maxScale.x),
            Mathf.Clamp(transform.localScale.y, minScale.y, maxScale.y),
            Mathf.Clamp(transform.localScale.z, minScale.z, maxScale.z)
        );
    }
}
