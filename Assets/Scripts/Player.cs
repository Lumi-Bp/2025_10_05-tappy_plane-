using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public int score = 0;
    public float jumpForce = 10f;
    public TextMeshProUGUI scoretext;
    // Start is called before the first frame update
    void Start()
    {
        rb =GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            rb.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse);
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
}
