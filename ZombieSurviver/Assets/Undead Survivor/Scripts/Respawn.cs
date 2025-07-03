using System;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform[] spawPoint;
    public SpawnData[] spawData;
    int level;
    float timer;

    void Awake()
    {
        spawPoint = GetComponentsInChildren<Transform>();
    }
    void Update()
    {
        timer += Time.deltaTime;
        level = Math.Min(Mathf.FloorToInt(GameManager.instance.gameTime / 10f), spawData.Length - 1);

        if (timer > spawData[level].spawnTime)
        {
            timer = 0;
            spawn();
        }
    }

    void spawn()
    {
        GameObject enemy = GameManager.instance.pool.Get(0);
        enemy.transform.position = spawPoint[UnityEngine.Random.Range(1, spawPoint.Length)].position;
        enemy.GetComponent<Enemy>().Init(spawData[level]);
    }
}

[System.Serializable]
public class SpawnData
{
    public int spriteType;
    public float spawnTime;
    public int health;
    public float speed;
}