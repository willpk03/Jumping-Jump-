using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeButtonGame : MonoBehaviour
{
    public int scene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onPress()
    {
        if (PlayerPrefs.GetInt("gameon") == 1)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(4);
        }
        else
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(scene);

        }
    }
}