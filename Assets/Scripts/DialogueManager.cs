using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private DialogueGraph graph;
    public static DialogueManager instance;
    [SerializeField] float Speed;
    [SerializeField] TMPro.TMP_Text DBox;
    [SerializeField] TMPro.TMP_Text PBox; //Mom found the piss drawer
    [SerializeField] TMPro.TMP_InputField field;


    bool isConfirm, isDisplay;

    [SerializeField] private string player;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    /*
    private void ProcessTextCall(DialogueData data) 
    {
        //Woah I can call this now!
        DBox.text = data.dialogue;
        PBox.text = data.name;
        DBox.maxVisibleCharacters = 0;

        //Do some coroutine
        StartCoroutine(DisplayText());
    }
    private void ProcessCharacterCall(CharacterData data) 
    {
        //Woah I can call this now!
        Charachter chara = CharacterManager.instance.GetById((int)data.Character);
        chara.MoveTo(data.position);
    }
    private void ProcessSelectionCall(SelectionNode SNode) 
    {
        if (SNode.GetOptions() == null) 
        {
            //Options are null, use special event
            SpecialEvent evnt = SNode.SEvent;
            switch (evnt) 
            {
                case SpecialEvent.None:
                    Debug.Log("EVENT IS NOT ASSIGNED, SELECTING DEFAULT");
                    SNode.selectOption(0);
                    break;
                case SpecialEvent.Arcade:
                    //Do arcade stuff
                    break;
                default:
                    break;
            }
            return;
        }
        //Process Generic Selection
    }
    private IEnumerator WaitForFinish(SelectionNode SNode) 
    {
        while (true) //Change to event manager
        {
            yield return null;
        }
        //Get data from event manager
    }*/
    public void SetName() 
    {
        player = field.text;
    }
    private void Start()
    {
        graph.Continue();
    }
    public void GetNextScene(Selection sel) 
    {
        switch (sel) {
            case Selection.name:
                StartCoroutine(WaitForName());
                break;
        }
    }
    public IEnumerator WaitForName()
    {
        //Option
        SelectionManager.instance.DisplayNamePrompt();

        while (player == string.Empty) { yield return null; }

        //Out Option
        SelectionManager.instance.HideNamePrompt();

        if (player.ToLower() == "steven")
        {
            graph.Continue();
        }
        else
        {
            graph.Continue(1);
        }
    }
    public void Text(string name, string text) 
    {
        if (player != string.Empty) text = text.Replace("[NAME]", player);
        DBox.text = text;
        if (player != string.Empty) name = name.Replace("[NAME]", player);
        PBox.text = name;
        DBox.maxVisibleCharacters = 0;

        StartCoroutine(DisplayText());
    }
    private IEnumerator DisplayText() 
    {
        isDisplay = true;
        foreach (char c in DBox.text) 
        {
            DBox.maxVisibleCharacters++;
            yield return new WaitForSeconds(Speed);
        }
        isDisplay = false;
        isConfirm = true;

        while (!Input.GetKeyDown(KeyCode.Z)) 
        {
            yield return null;
        }

        graph.Continue();
        yield break;
    }
}
public enum Selection 
{
    name,
    ice,
    arcade,
}