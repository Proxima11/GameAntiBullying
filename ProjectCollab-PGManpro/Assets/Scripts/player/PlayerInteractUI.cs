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
        containerGameObject.SetActive(true);
        interactTextMeshProUGUI.text = interactable.GetInteractText();
    }

    private void Hide() {
        containerGameObject.SetActive(false);
    }

}