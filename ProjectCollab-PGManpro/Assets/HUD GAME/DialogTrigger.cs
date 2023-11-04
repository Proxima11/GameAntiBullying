using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public TextAsset inkJSON;

    public void TriggerDialog(){
        FindObjectOfType<DialogManager>().StartDialogInk(inkJSON);
    }

    void Update(){
        if (Input.GetKeyUp(KeyCode.T)){
            TriggerDialog();
        }
    }

}
