using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChoiceScript2 : MonoBehaviour
{

    public GameObject TextBox;
    public GameObject Salah;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject Choice03;
    public int ChoiceMade;
    public bool isTrue = false;


    public void ChoiceOption1()
    {
        Salah.GetComponent<Text>().text=  "JAWABAN SALAH";
        ChoiceMade = 1;
    }

    public void ChoiceOption2()
    {
        Salah.GetComponent<Text>().text ="JAWABAN SALAH";
        ChoiceMade = 2;
    }
    public void ChoiceOption3()
    {
        TextBox.GetComponent<Text>().text= "Benar";
        ChoiceMade = 3;
    }

    void Update()
    {
        if (ChoiceMade == 3)
        {
            Choice03.SetActive(false);
            SceneManager.LoadScene(sceneBuildIndex: 6);
        } else if(ChoiceMade == 2)
        {
            Choice02.SetActive(true);
        } else if(ChoiceMade == 1)
        {
            Choice01.SetActive(true);
        }
    }
}
