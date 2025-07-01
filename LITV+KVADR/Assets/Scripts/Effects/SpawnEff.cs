using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEff : MonoBehaviour
{
    [SerializeField] private Button button;                       // Ссылка на кнопку
    [SerializeField] private GameObject effectPrefab;             // Префаб эффекта (например, маленькое изображение)
    [SerializeField] private float effectDuration = 1f;           // Время, через которое эффект будет исчезать
    [SerializeField] private RectTransform buttonRectTransform;    // RectTransform кнопки, который можно назначать через инспектор

    void Start()
    {
        // Если buttonRectTransform не назначен, пытаемся взять его из кнопки
        if (buttonRectTransform == null)
        {
            buttonRectTransform = button.GetComponent<RectTransform>();
        }

        // Подписываемся на событие нажатия на кнопку
        button.onClick.AddListener(OnButtonClick);
    }

    // Метод вызывается при нажатии на кнопку
    void OnButtonClick()
    {
        // Создаём эффект в случайном месте кнопки
        SpawnEffectAtRandomPosition();
    }

    // Спавн эффекта в случайной позиции внутри кнопки
    void SpawnEffectAtRandomPosition()
    {
        // Создаём экземпляр префаба эффекта как дочерний объект кнопки
        GameObject effectInstance = Instantiate(effectPrefab, button.transform);

        // Получаем RectTransform эффекта
        RectTransform effectRectTransform = effectInstance.GetComponent<RectTransform>();

        // Генерируем случайные координаты внутри кнопки
        float randomX = Random.Range(0, buttonRectTransform.rect.width) - (buttonRectTransform.rect.width / 2);
        float randomY = Random.Range(0, buttonRectTransform.rect.height) - (buttonRectTransform.rect.height / 2);

        // Устанавливаем позицию эффекта относительно кнопки
        effectRectTransform.anchoredPosition = new Vector2(randomX, randomY);

        // Запускаем корутину для удаления эффекта
        StartCoroutine(RemoveEffectAfterTime(effectInstance, effectDuration));
    }

    // Корутина для удаления эффекта через заданное время
    private IEnumerator RemoveEffectAfterTime(GameObject effect, float delay)
    {
        yield return new WaitForSeconds(delay); // Ждем заданное время
        Destroy(effect); // Удаляем эффект
    }
}
