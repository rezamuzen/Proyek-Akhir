using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DManager : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;
    // Start is called before the first frame update

    public bool dialogueActive;
    public string[] dialogLines;
    public int currentLine;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogueActive && Input.GetKeyDown(KeyCode.Escape))
        {
            
            currentLine++;
        }
        if(currentLine >= dialogLines.Length){
            Close();
            currentLine = 0;
        }
        dText.text = dialogLines[currentLine];  
    }
    public void Close(){
        dBox.SetActive(false); 
        dialogueActive = false;
    }
    public void ShowBox(string dialogue){
        dialogueActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
    }
    public void ShowDialogue(){
        dialogueActive = true;
        dBox.SetActive(true);
    }
}
