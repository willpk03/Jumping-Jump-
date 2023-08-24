using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SimpleAttack : MonoBehaviour
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
        System.Random rnd = new System.Random();
        int Attack = rnd.Next(6, 10);
        Debug.Log(Attack);
        UnityEngine.SceneManagement.SceneManager.LoadScene(Attack);

    }
}
