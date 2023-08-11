using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float startSpeed = 10f;

    [HideInInspector] // chỉ ẩn đúng dòng speed thôi
    public float speed;

    public float startHealth = 100;

    private float health;

    public int worth = 25;

    public GameObject deadthEffect;

    [Header("Unity Stuff")]
    public Image healthBar;

    private bool isDead = false;
    private void Start()
    {
        speed = startSpeed;
        health = startHealth;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;

        // giảm máu trong healthBar 
        // note: chỉ cần bỏ cái white square vào trong source image thì mình đổi được cái image type (cái quan trọng để hiện thanh giảm máu của enemy)
        healthBar.fillAmount = health / startHealth;

        if (health <= 0 && !isDead)
        {
            Die();
        }
    }

    public void Slow(float percent)
    {
        speed = startSpeed * (1 - percent);
    }

    void Die()
    {
        isDead = true;

        PlayerStats.Money += worth;

        GameObject effect = (GameObject)Instantiate(deadthEffect, transform.position, Quaternion.identity);
        Destroy(effect, 7f);

        WaveSpawner.EnemiesAlive--;

        Destroy(gameObject);
    }
}
