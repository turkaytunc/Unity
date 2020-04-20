using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    [SerializeField] private WaveConfig waveConfig;
    [SerializeField] private float movementSpeed = 5f;

    private List<Transform> waypoints;
    private int waypointIndex = 0;


    private void Start()
    {
        waypoints = waveConfig.GetWayPoints();
        transform.position = waypoints[waypointIndex].position;
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (waypointIndex < waypoints.Count)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].position, movementSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, waypoints[waypointIndex].position) < 0.3f)
            {
                waypointIndex++;
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
