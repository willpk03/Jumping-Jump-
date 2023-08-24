using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
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
        if (PlayerPrefs.HasKey("BossFights"))
        {
            int bossFights = PlayerPrefs.GetInt("BossFights");
            bossFights++;
            PlayerPrefs.DeleteAll();
            PlayerPrefs.SetInt("BossFights", bossFights);
        }
        else
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.SetInt("BossFights", 1);
        }
        

    }
}