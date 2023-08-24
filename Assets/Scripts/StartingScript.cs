using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class StartingScript : MonoBehaviour
{
    public TextMeshPro StartingMessage;
    public TextMeshPro TitleText;
    
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(BlinkText());
        if (PlayerPrefs.HasKey("gameon"))
        {
            TitleText.text = "jump JUMPING!!!";
        }
    }

    public IEnumerator BlinkText()
    {


        // Fancy pants flash of label on and off   
        

        if (PlayerPrefs.HasKey("gameon"))
        {
            TitleText.text = "jump JUMPING!!!";
        }
        else
        {
            while (true)
            {
                StartingMessage.text = "";
                yield return new WaitForSeconds(.5f);
                StartingMessage.text = "Tap the screen";
                yield return new WaitForSeconds(.5f);
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.HasKey("gameon"))
        {
            TitleText.text = "jump JUMPING!!!";
        }
        if (Input.GetMouseButtonDown(0))
        {
            //UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
    }

    public void onPress()
    {
        if (PlayerPrefs.HasKey("gameon")) {
            UnityEngine.SceneManagement.SceneManager.LoadScene(4);
        }
    }
}
