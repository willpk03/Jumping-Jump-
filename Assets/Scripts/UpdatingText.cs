using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdatingText : MonoBehaviour
{
    
    static int Coins;
    public TextMeshPro textMesH;
    // Start is called before the first frame update
    void Start()
    {
        textMesH = FindObjectOfType<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        textMesH.text = Coins.ToString();
    }
}
