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
            if (secondsLeft == 254) {
               nature.SetActive(true);
               factory.SetActive(false);
               if (!isFriend)
               {
                  Instantiate(friend, hugger.transform.position, Quaternion.identity);
                  isFriend = true;
               }
                Vector3 t = hugger.transform.position;
                t.y += 4;
                hugger.transform.position = t;
            }
        }
    }

    void GameOver()
    {
       gameOver = true;
       clock.text = "Game Over... try to support your frinds better next time, bud.";
    }
}
