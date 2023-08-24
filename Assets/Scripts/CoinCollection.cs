using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCollection : MonoBehaviour
{
    private int scoreValue = 0;
    public TextMeshPro textMesH;
    private string scoreValueTxt;

    int FUN;
    // Start is called before the first frame update
    void Start()
    {
        //textMesH = FindObjectOfType<TextMeshPro>();
        scoreValue = 0;
        SetScore();
        System.Random rnd = new System.Random();
        FUN = rnd.Next(0, 10);
        Debug.Log(FUN);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            collision.gameObject.SetActive(false);
            scoreValue += 1;
            SetScore();
            Debug.Log("You've collected" + scoreValue);
        
        }else if (collision.gameObject.tag == "pillar")
        {
            Debug.Log("Error should be appearing");
        }
        else 
        {
            if (PlayerPrefs.HasKey("bossHealth"))
            {
                Debug.Log("Hit something in bossmode");
                Application.LoadLevel(4);
            }
            else
            {
                endGame();
                Debug.Log("- Normal Trigger!");

                
                
                    Application.LoadLevel(0);
                    scoreValue = 0;
                    SetScore();
                

               
                
            }
        }
    }
    void SetScore()
    {
        scoreValueTxt = scoreValue.ToString();
        textMesH.text = "Coins: " + scoreValueTxt + "    Highscore: " + PlayerPrefs.GetInt("HighScore");
        Debug.Log("You've collected" + scoreValue + "|||| You have Banked:" + PlayerPrefs.GetInt("Coins"));

        if (PlayerPrefs.HasKey("DevModeStatus"))
        {
            if (scoreValue == 5 && PlayerPrefs.GetInt("DevModeStatus") == 1)
            {
                endGame();
                UnityEngine.SceneManagement.SceneManager.LoadScene(2);
            } 
        } else
        {
            if (scoreValue == 5)
            {
                endGame();
                UnityEngine.SceneManagement.SceneManager.LoadScene(2);
            }
        }
    }
    public void endGame()
    {

        if (PlayerPrefs.HasKey("HighScore"))
        {
            if (scoreValue >= PlayerPrefs.GetInt("HighScore"))
            {
                Debug.Log("You just got a highscore of" + scoreValue);
                PlayerPrefs.SetInt("HighScore", scoreValue);
            }
        }
        else
        {
            Debug.Log("It was identified you were playing for the first time:" + scoreValue);
            PlayerPrefs.SetInt("HighScore", scoreValue);
      }
        if (PlayerPrefs.HasKey("Coins"))
        {
            int Coins;
            Coins = scoreValue + PlayerPrefs.GetInt("Coins");
            PlayerPrefs.SetInt("Coins", Coins);
        }
        else
        {
            PlayerPrefs.SetInt("Coins", scoreValue);
      }
    }

}
