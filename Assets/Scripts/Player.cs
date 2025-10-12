using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour
{
    public GameObject spawner;
    private Rigidbody2D rb;
    public int score = 0;
    public float jumpForce = 10f;
    public TextMeshProUGUI scoretext;
    private AudioSource audioSource;

    public AudioClip jumpSource;
    public AudioClip deathSource;

    public ScoreBoard scoreBoard;


    // Start is called before the first frame update
    void Start()
    {
        rb =GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            rb.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse);
            audioSource.PlayOneShot(jumpSource);
        }
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Point"))
        {
            score++;
            scoretext.text = score.ToString();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        scoreBoard.ShowScore(score);
        audioSource.PlayOneShot(deathSource);
        spawner.SetActive(false); //disable
        Destroy(this); // removes player script
    }
}
