using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float health = 500;
    [SerializeField] private GameObject explosionPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int damage = collision.gameObject.GetComponent<DamageDealer>().GetDamage();

        health -= damage;

        if (health <= 0)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
