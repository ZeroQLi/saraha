using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform Player;
    public float speed = 3f;

    // create a reference to the player's transfor
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Player == null)
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            if (playerObject != null)
            {
                Player = playerObject.transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            Vector3 direction = (Player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
