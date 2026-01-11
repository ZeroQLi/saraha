using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public GameObject enemy;
    public LogicManager logic;

    void Start()
    {
        Time.timeScale = 1f;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f; // Disable gravity
    }

    void Update()
    {
        float h = 0f;
        float v = 0f;
        if (Input.GetKey(KeyCode.A)) h = -1f;
        if (Input.GetKey(KeyCode.D)) h = 1f;
        if (Input.GetKey(KeyCode.W)) v = 1f;
        if (Input.GetKey(KeyCode.S)) v = -1f;

        rb.linearVelocity = new Vector2(h * speed, v * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Debug.Log("hit enemy");
            logic.GameOver();
            Time.timeScale = 0f;
        }
    }
}
