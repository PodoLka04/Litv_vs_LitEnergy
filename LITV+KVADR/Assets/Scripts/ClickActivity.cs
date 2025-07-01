using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YG;

public class ClickActivity : MonoBehaviour
{
    public TMP_Text ScoreText;           // Текст для отображения очков
    public TMP_Text upgradeCostText;     // Текст для отображения стоимости апгрейда
    [SerializeField] private int upgradeCost = 300; // Стоимость улучшения
    private int score = 0;               // Инициализация переменной Score
    private int clickScore = 1;          // Инициализация переменной ClickScore


    void Start()
    {
        // Получаем значения из класса Data
        score = Data.Instance.GetScore();
        clickScore = Data.Instance.GetClickScore();
        upgradeCost = Data.Instance.GetupgradeCost();
    }


    public void Update()
    {
        // Обновляем текст на экране
        ScoreText.text = Data.Instance.score + " рублей";
        upgradeCostText.text = Data.Instance.upgradeCost + " рублей"; // Обновляем текст стоимости апгрейда
    }


    public void OnClickButton()
    {
        Data.Instance.score += Data.Instance.clickScore; // Добавляем clickScore к score

    }

    public void OnClickBuyLevel1() // функция покупки улучшения клика
    {
        if (Data.Instance.score >= Data.Instance.upgradeCost) // Проверяем, хватает ли очков на апгрейд
        {
            Data.Instance.score -= Data.Instance.upgradeCost; // Отнимаем стоимость апгрейда
            Data.Instance.clickScore *= 2;      // Увеличиваем очки за клик в 2 раза
            Data.Instance.upgradeCost *= 2;
            YandexGame.FullscreenShow();

        }
    }
}