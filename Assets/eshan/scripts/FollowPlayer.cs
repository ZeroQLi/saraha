using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float followDistance = 3f;
    public float moveSpeed = 2f;
    public float tooCloseDistance = 1f;

    void Update()
    {
        if (player == null)
            return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < tooCloseDistance)
        {
            // Too close - move away from player
            Vector3 direction = (transform.position - player.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
        if (distance > followDistance)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
    }
}
