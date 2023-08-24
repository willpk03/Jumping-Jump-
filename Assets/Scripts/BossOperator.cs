using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class BossOperator : MonoBehaviour
{

    public TMP_Text BossHealth;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("bossHealth"))
        {
            changetext();
        }else
        {
            PlayerPrefs.SetInt("bossHealth", 1000);
            changetext();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changetext()
    {
        BossHealth.text = "Health: " + PlayerPrefs.GetInt("bossHealth") + "hp";
    }
}
