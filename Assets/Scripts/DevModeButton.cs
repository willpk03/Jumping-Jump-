using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevModeButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pressed()
    {
        if (PlayerPrefs.HasKey("DevModeStatus"))
        {

            int i = PlayerPrefs.GetInt("DevModeStatus");
            if (i == 0)
            {
                PlayerPrefs.SetInt("DevModeStatus", 1);
            } else
            {
                PlayerPrefs.SetInt("DevModeStatus", 0);
            }
        }
        else
        {
            PlayerPrefs.SetInt("DevModeStatus", 0);
        }
 
    }
}
