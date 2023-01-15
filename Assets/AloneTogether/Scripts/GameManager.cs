using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private TextMeshProUGUI clock;
    private bool gameOver = false;
    //Our program main
    void Start()
    {
        Timer.Instance.StartTime(300, GameOver);
        clock = GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            clock.text = Timer.Instance.GetTimeLeft();
        }
    }

    void GameOver()
    {
       gameOver = true;
       clock.text = "Game Over... try to support your frinds better next time, bud.";
    }
}
