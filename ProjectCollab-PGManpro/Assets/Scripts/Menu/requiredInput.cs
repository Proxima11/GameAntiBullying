using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class requiredInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static string DrawRequiredInputField (string input)
{
  //cache default GUI color
  Color defColor = GUI.backgroundColor;

  bool isInvalid = string.IsNullOrEmpty(input);
  if (isInvalid) GUI.backgroundColor = new Color (1f, 0.67f, 0.7f);

  //if the given value is null, set it to an empty string to prevent errors when putting it in the TextField
  if (input == null) input = "";

  //create the actual text field
  string newInput = GUILayout.TextField(input);

  //reset GUI color
  GUI.backgroundColor = defColor;

  //prevent starting with a whitespace
  if (newInput.Length == 1 && newInput == " ") newInput = string.Empty;

  return newInput;
}

// newName = DrawRequiredInputField(name);
// if (string.IsNullOrEmpty(newName)) isInvalid = true;
}
