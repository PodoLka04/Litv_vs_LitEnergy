using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeepActive : MonoBehaviour
{
    public static KeepActive Instance { get; private set; } // Singleton для сохранения объекта

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
}
