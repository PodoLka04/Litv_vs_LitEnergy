using TMPro;
using UnityEngine;

public class Data : MonoBehaviour
{
    public static Data Instance { get; private set; }

    [SerializeField] public int score = 0;        // Начальное количество очков
    [SerializeField] public int clickScore = 1;
    [SerializeField] public bool boss1Win = false;//после победы для панелей и артефактов и кнопки на других боссов
    [SerializeField] public bool boss2Win = false;
    [SerializeField] public bool boss3Win = false;
    [SerializeField] public bool boss4Win = false;
    [SerializeField] public int upgradeCost = 300; // Стоимость улучшения

    [SerializeField] public bool isFirstTime = true;                 // Булевая переменная для первого запуска для босса с кузей
    [SerializeField] public bool key_kuzya = false;



    public bool key1 = true;
    public bool key2 = true;
    public bool key3 = true;
    public bool key4 = true;




    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Сохраняем объект между сценами
        }
        else
        {
            Destroy(gameObject); // Удаляем дубликаты
        }
    }

    public int GetScore()
    {
        return score;
    }
    public int GetClickScore()
    {
        return clickScore;
    }
    public bool Getboss1Win()
    {
        return boss1Win;
    }
    public bool Getboss2Win()
    {
        return boss2Win;
    }
    public bool Getboss3Win()
    {
        return boss3Win;
    }
    public bool Getboss4Win()
    {
        return boss4Win;
    }
    public int GetupgradeCost()
    {
        return upgradeCost;
    }
    public bool Getkey1()
    {
        return key1;
    }
    public bool Getkey2()
    {
        return key2;
    }
    public bool Getkey3()
    {
        return key3;
    }
    public bool Getkey4()
    {
        return key4;
    }

    public bool GetisFirstTime()
    {
        return isFirstTime;
    }
    public bool Getkey_kuzya()
    {
        return key_kuzya;
    }



    public void SetScore(int newScore)
    {
        score = newScore;
    }
    public void SetClickScore(int newClickScore)
    {
        clickScore = newClickScore;
    }
    public void Setboss1Win(bool newClickScore)
    {
        boss1Win = newClickScore;
    }
    public void Setboss2Win(bool newClickScore)
    {
        boss2Win = newClickScore;
    }
    public void Setboss3Win(bool newClickScore)
    {
        boss3Win = newClickScore;
    }
    public void Setboss4Win(bool newClickScore)
    {
        boss4Win = newClickScore;
    }
    public void SetupgradeCost(int newClickScore)
    {
        upgradeCost = newClickScore;
    }
    public void Setkey1(bool newClickScore)
    {
        key1 = newClickScore;
    }
    public void Setkey2(bool newClickScore)
    {
        key2 = newClickScore;
    }
    public void Setkey3(bool newClickScore)
    {
        key3 = newClickScore;
    }
    public void Setkey4(bool newClickScore)
    {
        key4 = newClickScore;
    }

    public void SetisFirstTime(bool newClickScore)
    {
        isFirstTime = newClickScore;
    }
    public void Setkey_kuzya(bool newClickScore)
    {
        key_kuzya = newClickScore;
    }
}
