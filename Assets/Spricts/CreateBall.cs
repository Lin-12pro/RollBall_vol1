using UnityEngine;

public class CreateBall : MonoBehaviour
{
    public GameObject Ball;
    public float Spawnspeed = 5f;

    void Start()
    {
        InvokeRepeating(nameof(Create), 0f, Spawnspeed);
    }

    void Create()
    {
        Instantiate(Ball, transform.position, Quaternion.identity);
    }
}
