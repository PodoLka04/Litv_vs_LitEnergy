using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class BossButton : MonoBehaviour
{
    /* public GameObject BossPan1;

    void Start()
    {
        BossPan1.SetActive(false);
    }

    public void ShowAndHideBoss1Pan()//----------------2
    {
        BossPan1.SetActive(!BossPan1.activeSelf);
    }*/


    public void Clickk()
    {
        if (Data.Instance.Getboss1Win() == false)
        {
            SceneManager.LoadScene("Boss");
        }

        if (Data.Instance.Getboss1Win() == true && Data.Instance.Getboss2Win() == false)
        {
            SceneManager.LoadScene("Boss 1");
        }
        
        if (Data.Instance.Getboss2Win() == true && Data.Instance.Getboss2Win() == true)
        {
            SceneManager.LoadScene("Boss 2");
        }

        if (Data.Instance.Getboss3Win() == true)
        {
            SceneManager.LoadScene("Boss 3");
        }
    }
}
