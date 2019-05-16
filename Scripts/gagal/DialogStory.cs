using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogStory : MonoBehaviour
{
    public Dialog dialog;
    public void TriggerDialog()
    {
        FindObjectOfType<DialogueManager>().StartDialog(dialog);
    }
}
