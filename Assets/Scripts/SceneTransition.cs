using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public void LoadScene(string scenename)
    {
        StartCoroutine(WaitAndThenLoadScene(scenename));
    }

    IEnumerator WaitAndThenLoadScene(string scenename)
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(scenename);
    }
}
