using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeIm2 : MonoBehaviour
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
        // Получаем компоненты RawImage и RectTransform
        rawImageComponent = GetComponent<RawImage>();
        rectTransform = GetComponent<RectTransform>();

        // Сохраняем текущее состояние ключа как предыдущее
        previousBoss1Key = Data.Instance.Getboss2Win();

        // Обновляем изображение и размер при старте
        UpdateImage();
    }

    void Update()
    {
        // Проверяем, изменилось ли значение boss1Key
        if (Data.Instance.Getboss2Win() != previousBoss1Key)
        {
            // Если значение изменилось, обновляем изображение и размер
            UpdateImage();

            // Обновляем предыдущее значение переменной
            previousBoss1Key = Data.Instance.Getboss2Win();
        }
    }

    // Метод для обновления изображения и размера в зависимости от состояния ключа
    void UpdateImage()
    {
        if (Data.Instance.Getboss2Win())
        {
            // Устанавливаем изображение и размер для состояния true
            rawImageComponent.texture = textureForTrue;
            rectTransform.sizeDelta = sizeForTrue;
        }
        else
        {
            // Устанавливаем изображение и размер для состояния false
            rawImageComponent.texture = textureForFalse;
            rectTransform.sizeDelta = sizeForFalse;
        }
    }
}
