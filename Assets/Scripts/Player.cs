using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public int score;
    public int highscore;
    public TMP_Text highscoreText;
    public TMP_Text scoreText;
    public Button restartButton;
    public float jumpSpeed;

    private void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, jumpSpeed);
        }
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * 5);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            score += 1;
            if(score > highscore)
            {
                highscore = score;
                highscoreText.text = "HIGHSCORE: " + highscore.ToString();
            }
            scoreText.text = score.ToString();
        }
    }

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            restartButton.gameObject.SetActive(true);
            highscoreText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
