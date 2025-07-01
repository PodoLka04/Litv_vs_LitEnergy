using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YG;  // Подключение Yandex Games SDK

public class yandex2 : MonoBehaviour
{
    [SerializeField] private Button advButton; // Ссылка на кнопку
    private float timer = 45f; // Таймер в секундах
    private bool buttonVisible = true; // Кнопка видна при старте
   
    public TMP_Text ScoreText;           // Текст для отображения денег
    public int saa = 500;


    // Подписка на события YandexGame при активации объекта
    private void OnEnable()
    {
        if (advButton != null) // Проверяем, назначена ли кнопка
        {
            advButton.onClick.AddListener(OnButtonClicked); // Добавляем слушатель клика на кнопку
        }

        YandexGame.RewardVideoEvent += Reward; // Подписываемся на событие награды за рекламу
    }

    // Отписка от событий YandexGame при деактивации объекта
    private void OnDisable()
    {
        if (advButton != null) // Проверяем, назначена ли кнопка
        {
            advButton.onClick.RemoveListener(OnButtonClicked); // Удаляем слушатель клика
        }

        YandexGame.RewardVideoEvent -= Reward; // Отписываемся от события награды за рекламу
    }

    void Start()
    {
        // Убедимся, что кнопка видима в начале
        advButton.gameObject.SetActive(true);
        buttonVisible = true;
    }

    void Update()
    {
        if (!buttonVisible) // Когда кнопка скрыта, начинаем отсчёт таймера
        {
            timer -= Time.deltaTime; // Уменьшаем таймер
            if (timer <= 0)
            {
                ShowButton(); // Показываем кнопку, когда таймер обнуляется
            }
        }
        if (Data.Instance.boss1Win == false)
        {
            saa = 500;
        }
        if (Data.Instance.boss1Win)
        {
            saa = 800;
        }
        if (Data.Instance.boss1Win && Data.Instance.boss2Win)
        {
            saa = 1000;
        }
        if (Data.Instance.boss1Win && Data.Instance.boss2Win && Data.Instance.boss3Win)
        {
            saa = 1200;
        }

        ScoreText.text = saa + " за рекламу";

    }

    // Метод для показа кнопки
    void ShowButton()
    {
        advButton.gameObject.SetActive(true); // Показываем кнопку
        buttonVisible = true; // Обновляем состояние
        timer = 45f; // Сбрасываем таймер на 30 секунд
    }

    // Метод вызывается при нажатии на кнопку
    public void OnButtonClicked()
    {
        advButton.gameObject.SetActive(false); // Скрываем кнопку
        buttonVisible = false; // Обновляем состояние
        YandexGame.RewVideoShow(1); // Показываем видео-рекламу через Yandex SDK
    }

    // Метод, который вызывается, когда реклама была просмотрена
    public void Reward(int id)
    {
        // Добавляем игроку награду за просмотр рекламы (например, 500 очков)
        Data.Instance.score += saa;
    }
}
