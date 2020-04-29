using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ApplePicker : MonoBehaviour
{
    [Header("Definiowane w panelu inspekcyjnym")]
    public GameObject basketPrefab;
    public int numBasket = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public float basketSpacingX= 5;
    public List<GameObject> basketList;
    public GameObject mainCanvas;
    public GameObject overCanvas;
    public GameObject scoreGO;
    public Text finalScore;
    // Start is called before the first frame update
    void Start()
    {
        basketList = new List<GameObject>();
        GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
        Vector3 pos = Vector3.zero;
        pos.y = -14f;
        tBasketGO.transform.position = pos;
        mainCanvas = GameObject.Find("Canvas");
        overCanvas = GameObject.Find("cGameOver");
        overCanvas.SetActive(false);
        
        basketList = new List<GameObject>();
        for (int i = 0; i < numBasket; i++)
        {
            GameObject ttBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos1 = new Vector3(20f,16f,0f);
            pos1.x -= basketSpacingX * i;
            ttBasketGO.transform.position = pos1;
            basketList.Add(ttBasketGO);
            ttBasketGO.GetComponent<Basket>().enabled = false;
            ttBasketGO.tag = "tagHealt";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach(GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }
        int basketIndex = basketList.Count-1;
        GameObject tBasketGO = basketList[basketIndex];
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGO);
        if(basketList.Count == 0)
        {
            
            scoreGO = GameObject.Find("ScoreCounter");
            Time.timeScale = 0f;
            mainCanvas.SetActive(false);
            overCanvas.SetActive(true);
            Text finalScore = scoreGO.GetComponent<Text>();
            
        }
    }
}
