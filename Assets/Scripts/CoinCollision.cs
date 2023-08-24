using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCollision : MonoBehaviour
{
    public static int Coins = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Coins);
       
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Collected a coin");
        gameObject.active = false;
        Coins = Coins + 1;
        Debug.Log("You have collected" + Coins);



}
}
