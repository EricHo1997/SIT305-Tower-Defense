using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float speed;

    public float startHealth = 100;
    private float health;

    public int value = 50;

    private Transform target;
    private int wavepointIndex = 0;

    [Header("Unity Stuff")]
    public Image healthBar;

    private bool isDead = false;

    void Start()
    {
        target = Waypoints.points[0];
        health = startHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        healthBar.fillAmount = health / startHealth;

        if (health <= 0 && !isDead)
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;

        PlayerStats.Money += value; // Increase the money when an enemy die

        WaveSpawner.EnemiesAlive--; 

        Destroy(gameObject);
    }

    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        // Make smooth movement for enemy
        this.transform.rotation = Quaternion.LookRotation(direction);

        if (Vector3.Distance(transform.position, target.position) <= 0.9f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            EndPath();
            return;
        }

        wavepointIndex++;

        target = Waypoints.points[wavepointIndex];
    }

    

    void EndPath()
    {
        PlayerStats.Lives--;
        WaveSpawner.EnemiesAlive--;
        Destroy(gameObject);
    }
}
