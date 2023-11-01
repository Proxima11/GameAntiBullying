using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;

    public void TriggerDialog(){
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }

    void Update(){
        if (Input.GetKeyUp(KeyCode.Y)){
            TriggerDialog();
        }

        if (Input.GetKeyDown(KeyCode.T)){
            FindObjectOfType<DialogManager>().DisplayNextSentences();
        }
    }

}
