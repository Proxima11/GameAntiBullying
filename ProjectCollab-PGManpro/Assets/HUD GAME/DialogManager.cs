using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text dialogText;

    public Queue<string> sentences;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    void Update(){
        if (Input.GetKeyUp(KeyCode.R)){
            DisplayNextSentences();
        }

    }

    public void StartDialog (Dialog dialog){
        animator.SetBool("isOpen", true);
        nameText.SetText(dialog.name);
        sentences.Clear();

        foreach (string sentence in dialog.sentences){
            sentences.Enqueue(sentence);
        }

        DisplayNextSentences();
    }

    public void DisplayNextSentences(){
        if (sentences.Count == 0){
            EndDialouge();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogText.SetText(sentence); 
        StopAllCoroutines();
        StartCoroutine(TypeSentences(sentence));
    }

    IEnumerator TypeSentences(string sentence){
        string textValue = "";
        dialogText.SetText("");

        foreach(char letter in sentence.ToCharArray()){
            textValue += letter;
            dialogText.SetText(textValue);
            yield return null;
        }
    }

    public void EndDialouge(){
        animator.SetBool("isOpen", false);
    }
}
