using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    private GameObject MainCanvas;
    private bool pause = false;
    public GameObject zzz;

    // Start is called before the first frame update
    void Start()
    {
        MainCanvas = GameObject.Find("Canvas");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            zzz = GameObject.FindWithTag("tagBasket");
            if (pause == false)
            {
                MainCanvas.SetActive(false);
                Time.timeScale = 0f;
                pause = true;
                zzz.GetComponent<Basket>().enabled = false;
            }
            else
            {
                MainCanvas.SetActive(true);
                Time.timeScale = 1f;
                pause = false;
                zzz.GetComponent<Basket>().enabled = true;
            }

           
                
        }
    }
}
