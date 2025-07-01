using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class PAnels : MonoBehaviour
{
    public GameObject ShopPan;
    public GameObject artefPan;
    public GameObject win1Pan;
    public GameObject win2Pan;
    public GameObject win3Pan;
    public GameObject win4Pan;


    // Start is called before the first frame update
    void Start()
    {
        ShopPan.SetActive(false);
        artefPan.SetActive(false);
        win1Pan.SetActive(false);
        win2Pan.SetActive(false);
        win3Pan.SetActive(false);
        win4Pan.SetActive(false);

    }

    public void ShowAndHideShopPan()//----------------2
    {
        ShopPan.SetActive(!ShopPan.activeSelf);
        YandexGame.FullscreenShow();

    }

    public void ShowAndHideArtefPan()//----------------2
    {
        artefPan.SetActive(!artefPan.activeSelf);
        YandexGame.FullscreenShow();

    }
    public void Hidewin1Pan()//----------------2
    {
        win1Pan.SetActive(false);
        YandexGame.FullscreenShow();

    }
    public void Hidewin2Pan()//----------------2
    {
        win2Pan.SetActive(false);
        YandexGame.FullscreenShow();

    }
    public void Hidewin3Pan()//----------------2
    {
        win3Pan.SetActive(false);
        YandexGame.FullscreenShow();

    }
    public void Hidewin4Pan()//----------------2
    {
        win4Pan.SetActive(false);
        YandexGame.FullscreenShow();

    }
}
