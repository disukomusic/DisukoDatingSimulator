using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public int scoreCounter;
    public Timer timer;
    public GameObject playerSprite;
    public Sprite idleSprite;
    public Sprite hitSprite;
    public TMP_Text score;
    
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        scoreCounter = 0;
        _spriteRenderer = playerSprite.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && timer._timeRemaining > 0)
        {
            scoreCounter++;
            score.text = scoreCounter.ToString();
            // StopAllCoroutines();
            StartCoroutine(attack());
        }
    }

    IEnumerator attack()
    {
        _spriteRenderer.sprite = hitSprite;

        yield return new WaitForSeconds(0.05f);
        _spriteRenderer.sprite = idleSprite;

    }
}
