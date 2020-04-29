using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Definiowane w panelu inspekcyjnym")]
    public GameObject applePrefab;
    public float speed = 1f; // Predkosc poruszania sie jabloni
    public float leftAndRightEdge = 10f; // Odleglosc od krawedzi ekranu, po przekroczeniu ktorej zmieni sie kierunek poruszania sie jabloni
    public float chanceToChangeDirections = 0.1f; // szansa ze jablon zmieni kierunek poruszania sie
    public float secondsBetweenAppleDrops = 1f; // czestopliwosc pojawiania sie jablek
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }
    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if(pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); // ruch w prawo
        }
        else if(pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); // Ruch w lewo
        }
    }
    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
}
