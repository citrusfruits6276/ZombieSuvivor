using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Scripts")]
    public Player player;

    public static GameManager instance;

    void Awake()
    {
        instance = this;
    }
}
