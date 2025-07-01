using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeIm1 : MonoBehaviour
{
    [SerializeField] private Texture textureForFalse; // Изображение для состояния false
    [SerializeField] private Texture textureForTrue;  // Изображение для состояния true

    [SerializeField] private Vector2 sizeForFalse = new Vector2(100, 100); // Размер для состояния false
    [SerializeField] private Vector2 sizeForTrue = new Vector2(200, 200);  // Размер для состояния true

    private bool previousBoss1Key; // Переменная для хранения предыдущего значения ключа
    private RawImage rawImageComponent; // Компонент для UI элемента RawImage
    private RectTransform rectTransform; // Компонент RectTransform для изменения размеров


    void Start()
    {
        // Получаем компонент RawImage
        rawImageComponent = GetComponent<RawImage>();
        rectTransform = GetComponent<RectTransform>();


        // Сохраняем текущее состояние ключа как предыдущее
        previousBoss1Key = Data.Instance.Getboss1Win();

        // Обновляем изображение при старте
        UpdateImage();
    }

    void Update()
    {
        // Проверяем, изменилось ли значение boss1Key
        if (Data.Instance.Getboss1Win() != previousBoss1Key)
        {
            // Если значение изменилось, обновляем изображение
            UpdateImage();

            // Обновляем предыдущее значение переменной
            previousBoss1Key = Data.Instance.Getboss1Win();
        }
    }

    // Метод для обновления изображения в зависимости от состояния ключа
    void UpdateImage()
    {
        if (Data.Instance.Getboss1Win())
        {
            // Устанавливаем изображение для состояния true
            rawImageComponent.texture = textureForTrue;
            rectTransform.sizeDelta = sizeForTrue;

        }
        else
        {
            // Устанавливаем изображение для состояния false
            rawImageComponent.texture = textureForFalse;
            rectTransform.sizeDelta = sizeForFalse;

        }
    }
}
