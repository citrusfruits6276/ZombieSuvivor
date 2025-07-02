using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform[] spawPoint;
    float timer;
    void Awake()
    {
        spawPoint = GetComponentsInChildren<Transform>();
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 0.2f)
        {
            timer = 0;
            spawn();
        }
    }

    void spawn()
    {
        GameObject enemy = GameManager.instance.pool.Get(Random.Range(0, 2));
        enemy.transform.position = spawPoint[Random.Range(1, spawPoint.Length)].position;
    }
}
