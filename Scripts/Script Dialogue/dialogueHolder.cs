using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dialogueHolder : MonoBehaviour
{
    public string dialogue;
    private DManager dMAn;
    public string[] dialogLines;
    // Start is called before the first frame update
    void Start()
    {
        dMAn = FindObjectOfType<DManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other){
        if (other.gameObject.name == "Player")
        {
            // dMAn.ShowBox(dialogue);
            if(!dMAn.dialogueActive){
                dMAn.dialogLines = dialogLines;
                dMAn.currentLine = 0 ;
                dMAn.ShowDialogue();
            }
        }
    }
}
