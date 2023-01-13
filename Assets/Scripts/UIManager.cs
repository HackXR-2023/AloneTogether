using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu; 
    void Start()
    {
        ShowMenu();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMenu() 
    {
        Instantiate(menu);
    }

    public void HideMenu()
    {
        Destroy(menu);
    }
}
