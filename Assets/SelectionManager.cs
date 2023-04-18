using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour
{
    public static SelectionManager instance;
    public Image backdrop;
    public GameObject NamePrompt, ThreeChoice, TwoChoice;
    private void Awake()
    {
        if(!instance) instance = this;
    }

    public void DisplayNamePrompt() 
    {
        backdrop.color = new Color(0, 0, 0, 0.25f);
        NamePrompt.SetActive(true);
    }
    public void HideNamePrompt() 
    {
        backdrop.color = new Color(0, 0, 0, 0f);
        NamePrompt.SetActive(false);
    }
    public void DisplayChoices(string[] options)
    {
        backdrop.color = new Color(0, 0, 0, 0.25f);
        switch (options.Length) 
        {
            case 1:
                break;
            case 2:
                TwoChoice.SetActive(true);
                TwoChoice.GetComponentsInChildren<TMPro.TMP_Text>()[0].text = options[0];
                TwoChoice.GetComponentsInChildren<TMPro.TMP_Text>()[1].text = options[1];
                break;
            case 3:
                ThreeChoice.SetActive(true);
                ThreeChoice.GetComponentsInChildren<TMPro.TMP_Text>()[0].text = options[0];
                ThreeChoice.GetComponentsInChildren<TMPro.TMP_Text>()[1].text = options[1];
                ThreeChoice.GetComponentsInChildren<TMPro.TMP_Text>()[2].text = options[2];
                break;
        }
    }
    public void SetVariable() 
    {

    }
    public void HideChoices()
    {
        TwoChoice.SetActive(false);
        ThreeChoice.SetActive(false);
    }
}
