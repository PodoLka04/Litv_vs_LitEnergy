using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks.Sources;
using Unity.VisualScripting;
using UnityEngine;

public class AfterWinPanels : MonoBehaviour
{
    public GameObject win1Pan;
    public GameObject win2Pan;
    public GameObject win3Pan;
    public GameObject win4Pan;
    

    void Start()
    {
        win1Pan.SetActive(false);
        win2Pan.SetActive(false);
        win3Pan.SetActive(false);
        win4Pan.SetActive(false);
    }

    private void Update()
    {
        if (Data.Instance.Getboss1Win() == true && Data.Instance.Getkey1() == true)
        {
            Data.Instance.Setkey1(false);
            win1Pan.SetActive(true);
        }
        if (Data.Instance.Getboss2Win() == true && Data.Instance.Getkey2() == true)
        {
            Data.Instance.Setkey2(false);
            win2Pan.SetActive(true);
        }
        if (Data.Instance.Getboss3Win() == true && Data.Instance.Getkey3() == true)
        {
            Data.Instance.Setkey3(false);
            win3Pan.SetActive(true);
        }
        if (Data.Instance.Getboss4Win() == true && Data.Instance.Getkey4() == true)
        {
            Data.Instance.Setkey4(false);
            win4Pan.SetActive(true);
        }
    }


}
