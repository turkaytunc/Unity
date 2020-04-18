using UnityEngine;

public class Laser : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    [SerializeField] private float laserVelocity = 20f;


    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        rigidbody2D.velocity = new Vector2(0, laserVelocity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
