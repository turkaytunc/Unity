using UnityEngine;

public class Laser : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [SerializeField] private float laserVelocity = 20f;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

        rb2D.velocity = new Vector2(0, laserVelocity);

        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
