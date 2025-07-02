using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Scripts")]
    public Player player;

    public static GameManager instance;

    public PoolManager pool;

    void Awake()
    {
        instance = this;
    }
}
