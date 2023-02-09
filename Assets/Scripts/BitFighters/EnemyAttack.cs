using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int enemyCounter;
    public Timer timer;
    public GameObject enemySprite;
    public Sprite idleSprite;
    public Sprite hitSprite;
    public TMP_Text score;
    
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        enemyCounter = 0;
        _spriteRenderer = enemySprite.GetComponent<SpriteRenderer>();
        StartCoroutine(attack());
    }
    
    IEnumerator attack()
    {
        while(timer._timeRemaining > 0)
        {
            _spriteRenderer.sprite = hitSprite;
            yield return new WaitForSeconds(0.05f);
            score.text = enemyCounter.ToString();
            enemyCounter++;
            _spriteRenderer.sprite = idleSprite;
            yield return new WaitForSeconds(Random.Range(0.05f,0.1f));
        }
    }
}
