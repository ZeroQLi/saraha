using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public Transform[] spawnPoints;
    public float spawnRate;
    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnEnemy();
            timer = 0;
        }
    }
    void SpawnEnemy()
    {
        if (spawnPoints.Length > 0)
        {
            int index = Random.Range(0, spawnPoints.Length);
            transform.position = spawnPoints[index].position;
            Instantiate(EnemyPrefab, transform.position, transform.rotation);
        }
        else
        {
            Instantiate(EnemyPrefab, transform.position, transform.rotation);
        }
    }
}
