using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyMovement : MonoBehaviour
{
    private Transform target;
    private int waypointsIndex = 0;

    private Enemy enemy;
    private void Start()
    {
        enemy = GetComponent<Enemy>();

        target = Waypoints.points[0];
    }

    private void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * enemy.speed * Time.deltaTime, Space.World); // giup cho enemy di chuyen duoc

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWayPoint();
        }
        enemy.speed = enemy.startSpeed;
    }

    private void GetNextWayPoint()
    {
        if (waypointsIndex >= Waypoints.points.Length - 1)
        {
            EndPath();
            return;
        }

        waypointsIndex++;
        target = Waypoints.points[waypointsIndex];
    }
    void EndPath()
    {
        PlayerStats.Lives--;
        WaveSpawner.EnemiesAlive--;
        Destroy(gameObject);
    }
}
