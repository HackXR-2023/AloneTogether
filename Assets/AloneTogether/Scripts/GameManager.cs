using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private TextMeshProUGUI clock;
    private bool gameOver = false;
    //Our program main

    public GameObject friend;
    public GameObject nature;
    public GameObject factory;
    public GameObject hugger;
    bool isFriend = false;
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
            int secondsLeft = Timer.Instance.GetSecondsLeft();
            if (secondsLeft == 234) {
               nature.SetActive(true);
               factory.SetActive(false);
               Vector3 t = hugger.transform.position;
               t.y += 2;
               hugger.transform.position = t;
               if (!isFriend)
               {
                  Instantiate(friend, hugger.transform.position, Quaternion.identity);
                  isFriend = true;
               }
              
            }
        }
    }

    void GameOver()
    {
       gameOver = true;
       clock.text = "Game Over... try to support your frinds better next time, bud.";
    }
}
