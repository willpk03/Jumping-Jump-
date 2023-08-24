using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class BankUpdateText : MonoBehaviour
{
    public TextMeshPro bankTotal;
    // Start is called before the first frame update
    void Start()
    {
        
        bankTotal.text = "Bank: " + PlayerPrefs.GetInt("Coins");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
