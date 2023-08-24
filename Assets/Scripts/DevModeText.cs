using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class DevModeText : MonoBehaviour
{

    public TMP_Text DevStatus;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        DevStatus = GetComponent<TMP_Text>();
        int i;
        if (PlayerPrefs.HasKey("DevModeStatus"))
        {
            
        } else
        {
            PlayerPrefs.SetInt("DevModeStatus", 0);
        }
        DevModeStatusCheck();
        
    }

    // Update is called once per frame
    void Update()
    {
        
            DevModeStatusCheck();
        
    }

    public void DevModeStatusCheck()
    {
        i = PlayerPrefs.GetInt("DevModeStatus");
        if(i == 0)
        {
            DevStatus.text = "DevMode is currently: Off";
        } else if (i == 1)
        {
            DevStatus.text = "DevMode is currently: On";
        } else
        {
            DevStatus.text = "DevMode is currently not working";
        }
       
    }
}
