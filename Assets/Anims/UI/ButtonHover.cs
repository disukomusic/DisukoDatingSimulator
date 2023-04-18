using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHover : MonoBehaviour
{
    public void OnHover()
    {
        GetComponent<Animator>().SetBool("isHovered", true);
    }
    public void OffHover()
    {
        GetComponent<Animator>().SetBool("isHovered", false);

    }
}
