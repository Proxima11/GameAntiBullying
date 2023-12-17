using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Achievements_util : MonoBehaviour {
    
[SerializeField] private TMP_Text tMP_Text;
private string note;
public void setNote(){
    tMP_Text.text = note;
}

public void setNote(string note){
    this.note = note;
}
}
