using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class playerControlSceneDojo : MonoBehaviour
{


    public Rigidbody2D rb;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;
    public AudioClip sound;
    public int checker;
    public TMP_Text cutscenetxt;
    public GameObject background;
    public GameObject pillar;
    public GameObject chatbox;
    public GameObject scoreText;
    public GameObject CharProfile;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        StartCoroutine(BlinkText("Now begin jumping, try to push that pillar."));
    }

    // Update is called once per frame
    void Update()

    {
        //Each Cutscene takes 4 points 
        //State 1 - Running text Message
        //State 2 - Text Message is over
        //State 3 - Began Jumping
        //State 4 - Hit wall

        if (checker == 4)
        {
            StartCoroutine(BlinkText("Don't give up try again."));
        } else if (checker == 8)
        {
            StartCoroutine(BlinkText("Keep trying, you can do it."));
        } else if (checker == 12)
        {
            StartCoroutine(BlinkText("You must put more force into it. Make it Spin!"));
        } else if (checker >= 18)
        {
            pillar.transform.transform.Rotate(0, 0, 1);
        } else if (checker == 16)
        {
            StartCoroutine(BlinkText("Well done, you did it! Now collect that coin."));
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (checker == 2 || checker == 6 || checker == 10 || checker == 14 || checker == 18 || checker == 3 || checker == 7 || checker == 11 || checker == 15 || checker == 19)
            {
                rb.velocity = new Vector2(0, 5);
                if (checker == 2 || checker == 6 || checker == 10 || checker == 14 || checker == 18) 
                {
                    background.SetActive(false);
                    chatbox.SetActive(false);
                    scoreText.SetActive(false);
                    CharProfile.SetActive(false);
                    checker++;
                }
            }
            else
            {

            }

        }


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            Debug.Log("Touching Ground");

        }
    }

    public IEnumerator BlinkText(string fulltext)
    {
        checker++;
        background.SetActive(true);
        chatbox.SetActive(true);
        scoreText.SetActive(true);
        CharProfile.SetActive(true);
        //Grabs text and create a slowly loading text
        string updatedtext = " ";


        string[] fulltextA = fulltext.Split(' ');
        Debug.Log("Working?");
        int x = 0;
        Debug.Log("Now begin jumping, try to avoid that pillar or it might hurt.");

        Color whateverColor = Color.blue;
        SpriteRenderer gameObjectRenderer = background.GetComponent<SpriteRenderer>();
        Material newMaterial = new Material(Shader.Find("Diffuse"));
        newMaterial.color = whateverColor;
        gameObjectRenderer.material = newMaterial;

        while (x != fulltextA.Length)
        {

            Debug.Log(fulltextA[x]);
            Debug.Log(x);
            updatedtext = updatedtext + " " + fulltextA[x];
            cutscenetxt.text = updatedtext;
            yield return new WaitForSeconds(.35f);
            x++;
        }
        checker++;



        Debug.Log(checker);




    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pillar")
        {
            transform.position = new Vector3(0, -6, 0);
            checker++;

        } else if (collision.gameObject.tag == "Tutorial Coin")
        {
            Debug.Log("Collected coin");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
}
