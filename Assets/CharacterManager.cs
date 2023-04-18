using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public static CharacterManager instance;
    [SerializeField] Charachter[] Characters;
    [SerializeField] Charachter[] CharInUse;
    public void Awake()
    {
        if (!instance) instance = this;
    }
    public Charachter GetById(int Id) 
    {
        foreach (Charachter cha in CharInUse) 
        {
            if (cha.id == Id) return cha; 
        }
        return null;
    }
}
public enum Cast 
{
    Disuko = 0,
    Shiku = 1,

}
