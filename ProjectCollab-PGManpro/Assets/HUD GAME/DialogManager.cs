using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;

public class DialogManager : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text dialogText;

    public Queue<string> sentences;

    public Story currentStory;

    public Animator animator;

    [SerializeField] private GameObject[] choices;
    private TMP_Text[] choicesText;

    private bool isChoices = false;

    private const string SPEAKER_TAG = "speaker";

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        choicesText = new TMP_Text[choices.Length];
        int index = 0;
        foreach(GameObject choice in choices){
            choicesText[index]= choice.GetComponentInChildren<TMP_Text>();
            index++;
        }
    }

    void Update(){
        if (Input.GetKeyUp(KeyCode.R)){
            continueStory();
        }

    }

    public void StartDialogInk(TextAsset inkJSON){
        animator.SetBool("isOpen", true);

        currentStory = new Story(inkJSON.text);
        
        continueStory();
    }

    public void continueStory(){
        if (!isChoices){
            string text = "";
            if(currentStory.canContinue){
                text = currentStory.Continue();
                displayChoices();
                handleTags(currentStory.currentTags);
            }else{
                EndDialouge();
            }

            dialogText.SetText(text); 
            StopAllCoroutines();
            StartCoroutine(TypeSentences(text));
        }
    }

    private void handleTags(List<string> currentTags){
        foreach(string tag in currentTags){
            string[] splitTag = tag.Split(':');
            if(splitTag.Length != 2){
                Debug.LogError("Tag could not be apropriately parsed" + tag);
            }

            string tagKey = splitTag[0].Trim();
            string tagValue = splitTag[1].Trim();

            switch (tagKey){
                case SPEAKER_TAG:
                    // Debug.Log("speaker: "+ tagValue);
                    nameText.SetText(tagValue);
                    break;
            }
        }
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

    public void displayChoices(){
        
        List<Choice> currentChoices = currentStory.currentChoices;
        
        if (currentChoices.Count > choices.Length){
            Debug.LogError("More Choices were given than the UI can support. Number of choices given: " + currentChoices.Count);
        }

        int index = 0;
        foreach(Choice choice in currentChoices){
            choices[index].gameObject.SetActive(true);
            choicesText[index].SetText(choice.text);
            index++;
        }

        if(index!=0){
            isChoices = true;
        }

        for (int i=index; i< choices.Length;i++){
            choices[i].gameObject.SetActive(false);
        }


        StartCoroutine(selectFirstChoice());
    }

    private IEnumerator selectFirstChoice(){
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }

    public void MakeChoices(int choiceIndex){
        Debug.Log(choiceIndex);
        currentStory.ChooseChoiceIndex(choiceIndex);
        foreach(GameObject choice in choices){
            choice.gameObject.SetActive(false);
        }
        isChoices= false;
        continueStory();
    }
}
