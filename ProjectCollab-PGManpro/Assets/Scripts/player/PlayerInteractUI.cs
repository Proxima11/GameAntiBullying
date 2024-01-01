using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerInteractUI : MonoBehaviour {

    [SerializeField] private GameObject containerGameObject;
    [SerializeField] private PlayerInteract playerInteractBoy;
    [SerializeField] private PlayerInteract playerInteractGirl;
    [SerializeField] private TextMeshProUGUI interactTextMeshProUGUI;

    private void Update() {
        if (superScript.boy){
            if (playerInteractBoy.GetInteractableObject() != null) {
                Show(playerInteractBoy.GetInteractableObject());
            } else {
                Hide();
            }
        } else {
                if (playerInteractGirl.GetInteractableObject() != null) {
                Show(playerInteractGirl.GetInteractableObject());
            } else {
                Hide();
            }
        }
    }

    private void Show(InterfaceInteractable interactable) {
        if (interactable is TeleportCollisionQuiz){
            int i_temp = interactable.GetInteractText().IndexOf("quiz");
            string quiz_temp = interactable.GetInteractText().Substring(i_temp);

            switch (quiz_temp){
                case "quiz ips":
                if (superScript.done_quiz[0] == 1) return;
                break;

                case "quiz ipa":
                if (superScript.done_quiz[1] == 1) return;
                break;

                case "quiz mat":
                if (superScript.done_quiz[2] == 1) return;
                break;

                case "quiz indo":
                if (superScript.done_quiz[3] == 1) return;
                break;

                case "quiz eng":
                if (superScript.done_quiz[4] == 1) return;
                break;
            }
        }

        containerGameObject.SetActive(true);
        interactTextMeshProUGUI.text = interactable.GetInteractText();
    }

    private void Hide() {
        containerGameObject.SetActive(false);
    }

}