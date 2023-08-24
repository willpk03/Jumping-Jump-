using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsPageOpen : MonoBehaviour
{
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
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
