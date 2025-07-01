
using UnityEngine;

namespace YG
{
    [System.Serializable]
    public class SavesYG
    {

        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;

        // Тестовые сохранения для демо сцены
        // Можно удалить этот код, но тогда удалите и демо (папка Example)
        public int money = 1;                       // Можно задать полям значения по умолчанию
        public string newPlayerName = "Hello!";
        public bool[] openLevels = new bool[3];

        // Ваши сохранения

        public int Score = 0;
        public int ClickScore = 1;
        public int CostInt = 100;

        public bool key1 = true;//открыл только пока панель открыта 
        public bool key2 = true;
        public bool key3 = true;
        public bool key4 = true;

        public bool boss1Win = false; // открыл раз и на всегда
        public bool boss2Win = false;
        public bool boss3Win = false;
        public bool boss4Win = false;

        public int upgradeCost = 1000;
        public bool isFirstTime = true;
        public bool key_kuzya = false;

        // Поля (сохранения) можно удалять и создавать новые. При обновлении игры сохранения ломаться не должны


        // Вы можете выполнить какие то действия при загрузке сохранений
        public SavesYG()
        {
            // Допустим, задать значения по умолчанию для отдельных элементов массива

            openLevels[1] = true;
        }
    }
}
