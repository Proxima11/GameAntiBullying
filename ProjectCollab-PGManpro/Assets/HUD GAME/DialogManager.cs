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
    public TMP_Text blackScreenText;

    public Queue<string> sentences;
    public Story currentStory;
    public Animator animator;
    public Animator animatorBlackScreen;
    public float TypingSpeed = 0.04f;
    private Coroutine displayLineCoroutine;
    private string currentTextRunning;
    [SerializeField] private GameObject[] choices;
    private TMP_Text[] choicesText;

    private bool canContinueToNextLine = false;
    private bool isChoices = false;
    private bool isDialogBlackscreen = false;

    private const string SPEAKER_TAG = "speaker";
    private const string BLACKSCREEN_TAG = "blackscreen";

    public GameObject taskbutton;
    //public GameObject settingbutton;

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
            if (canContinueToNextLine){
                continueStory();
            }else if(!isDialogBlackscreen){
                skipText();
            }
        }
    }

    public void StartDialogInk(TextAsset inkJSON){
        animator.SetBool("isOpen", true);

        currentStory = new Story(inkJSON.text);
        nameText.SetText("xxx");

        continueStory();
    }

    public void continueStory(){
        if (!isChoices){
            currentTextRunning = "";
            if(currentStory.canContinue){
                currentTextRunning = currentStory.Continue();
                handleTags(currentStory.currentTags);
            }else{
                EndDialouge();
            }

            if (isDialogBlackscreen){
                Debug.Log("blackscreen");
                animatorBlackScreen.SetBool("isStart", true);
                taskbutton.SetActive(false);
                //settingbutton.SetActive(false);

                blackScreenText.SetText(currentTextRunning);
                if(displayLineCoroutine!=null){
                    StopCoroutine(displayLineCoroutine);
                }
                displayLineCoroutine = StartCoroutine(TypeSentences(currentTextRunning));
                StartCoroutine(closeBlackScreen());
            }else {
                dialogText.SetText(currentTextRunning); 
                if(displayLineCoroutine!=null){
                    StopCoroutine(displayLineCoroutine);
                }
                displayLineCoroutine = StartCoroutine(TypeSentences(currentTextRunning));
            }
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
                    if (tagValue == "narrator"){
                        isDialogBlackscreen = true;
                        
                    }else {
                        nameText.SetText(tagValue);
                    }
                    break;
            }
        }
    }

    IEnumerator TypeSentences(string sentence){
        string textValue = "";
        dialogText.SetText("");

        hideChoices();
        canContinueToNextLine = false;

        foreach(char letter in sentence.ToCharArray()){
            textValue += letter;
            if (isDialogBlackscreen){
                blackScreenText.SetText(textValue);
            }else{
                dialogText.SetText(textValue);
            }
            yield return new WaitForSeconds(TypingSpeed);
        }

        displayChoices();
        canContinueToNextLine = true;
    }

    public void EndDialouge(){
        animator.SetBool("isOpen", false);
        superScript.indexDialog = superScript.indexDialog + 1;
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
        if (canContinueToNextLine){
            currentStory.ChooseChoiceIndex(choiceIndex);
            hideChoices();
            isChoices= false;
            continueStory();
        }
    }

    public void hideChoices(){
        foreach(GameObject choice in choices){
            choice.gameObject.SetActive(false);
        }
    }

    public void skipText(){
        StopCoroutine(displayLineCoroutine);
        dialogText.SetText(currentTextRunning);
        canContinueToNextLine = true;
        displayChoices();
    }

    public IEnumerator closeBlackScreen(){
        yield return new WaitForSeconds(2);
        animatorBlackScreen.SetBool("isStart", false);
        isDialogBlackscreen = false;
        taskbutton.SetActive(true);
        //settingbutton.SetActive(true);
        continueStory();
    }
}
