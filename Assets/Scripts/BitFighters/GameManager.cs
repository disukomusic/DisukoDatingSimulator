using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public Timer timer;
    public PlayerInput player;
    public EnemyAttack enemy;
    public GameObject winText;
    public GameObject loseText;
    public bool canAttack;
    
    void Start()
    {

        timer.StartTimer();
        timer.OnTimerDone += CompareScores;
        

    }
    
    void CompareScores()
    {
        if (player.scoreCounter > enemy.enemyCounter)
        {
            winText.SetActive(true);
            timer.timeText.SetText(" ");
            return;
        }
        timer.timeText.SetText(" ");
        loseText.SetActive(true);
    }
}
