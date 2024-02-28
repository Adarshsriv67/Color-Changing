using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float jumpHeight = 4f;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public string currentColor;
    public Color redColor;
    public AudioClip jump;
    public AudioClip bg;
    public Color yellowColor;
    public Color blueColor;
    public Color greenColor;
    private UIManager uiManager;

    void Start()
    {
        AudioSource.PlayClipAtPoint(bg, Camera.main.transform.position);
        uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        rb = GetComponent<Rigidbody2D>();
        randomColor();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButton(0))
        {
            rb.velocity = Vector2.up * jumpHeight;
            AudioSource.PlayClipAtPoint(jump, Camera.main.transform.position);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="ColorChanger")
        {
            randomColor();
            Destroy(collision.gameObject);
            return;
        }
        if (collision.tag != currentColor)
        {
            Debug.Log("GAME OVER!!!");
            SceneManager.LoadScene("GameOver");
        }
        else if(collision.tag==currentColor)
        {
            uiManager.UpdateScore();
        }
        else if (collision.tag == "over")
        {
            SceneManager.LoadScene("Mainmenu");
        }
        Debug.Log(collision.tag);
    }

    void randomColor()
    {
        int index = Random.Range(0, 4);
        if(index==0)
        {
            currentColor = "red";
            sr.color = redColor;

        }
        else if(index==1)
        {
            currentColor = "yellow";
            sr.color = yellowColor;
        }
        else if(index==2)
        {
            currentColor = "blue";
            sr.color = blueColor;
        }
        else if(index==3)
        {
            currentColor = "green";
            sr.color = greenColor;
        }
    }
}
