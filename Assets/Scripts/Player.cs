using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public int points;
    public TMP_Text pointsText;
    public Button restartButton;
    public float jumpSpeed;

    private void Start()
    {
        points = 0;
        pointsText.text = points.ToString();
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
            points += 1;
            pointsText.text = points.ToString();
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
            Time.timeScale = 0;
        }
    }
}
