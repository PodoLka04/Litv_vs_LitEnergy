/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kyzia : MonoBehaviour
{
    public GameObject Kyzia1Pan;
    public GameObject Kyzia2Pan;
    public GameObject Kyzia3Pan;

    public AudioSource k1;
    public AudioSource k2;
    public AudioSource k3;

    private void Start()
    {
        Kyzia1Pan.SetActive(false);
        Kyzia2Pan.SetActive(false);
        Kyzia3Pan.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Data.Instance.Getkey_kuzya() == false)
        {
            Kyzia1Pan.SetActive(true);
            //k1.Play();
        }
    }
    public void FirstClick()
    {
        Kyzia1Pan.SetActive(false);
        Kyzia2Pan.SetActive(true);
        Data.Instance.Setkey_kuzya(true);
        k2.Play();
    }
    public void SecondClick()
    {
        Kyzia2Pan.SetActive(false);
        Kyzia3Pan.SetActive(true);
        k3.Play();
    }
    public void FinalClick()
    {
        Kyzia3Pan.SetActive(false);
    }
}*/
