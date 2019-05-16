using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject : MonoBehaviour
{
    public int questNumber;
    public QuestManager thQM;

    public string startText;
    public string endText;
    // Start is called before the first frame update
    void Start() 
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartQuest(){
        thQM.ShowQuestText(startText);
    }
    public void EndQuest(){
        thQM.ShowQuestText(endText);
        thQM.questCompleted[questNumber] = true;
        gameObject.SetActive(false);
    }
}
