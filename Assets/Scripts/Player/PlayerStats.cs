using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class PlayerStats : MonoBehaviour
{
    [Header("Start Stats")]
    public Stats data;
    private int health;
    private int exp;
    [Header("Stats saver")]
    private PlayerData playerData;
    void Start()
    {
        data.UpdateStats();
        health = data.maxHealth;
    }

    public void Heal(int amount)
    {
        health += amount;
        if(health > data.maxHealth)
        {
            health = data.maxHealth;
        }
    }

    public void Heal(float percentage)
    {
        int healAmount = Mathf.FloorToInt((data.maxHealth - health) * percentage);
        health += healAmount;
        if(health > data.maxHealth)
        {
            health = data.maxHealth;
        }
    }
    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
            Die();
            return;
        }
    }

    public void GainExp(int amount)
    {
        exp += amount;
        if(exp >= data.experienceToLevelUp)
        {
            exp -= data.experienceToLevelUp;
            LevelUp();
        }
    }

    private void LevelUp()
    {
        data.level++;
        float healthPercent = (float)health / data.maxHealth;
        int healAmount = Mathf.FloorToInt((data.maxHealth - health) * 0.1f);
        data.UpdateStats();
        health = Mathf.FloorToInt(data.maxHealth * healthPercent) + healAmount;
    }

    public void Die()
    {
        Player.instance.animator.SetTrigger("death");
        Debug.Log("Player has died.");
    }
    public int GetHealth()
    {
        return health;
    }
    public int GetExp()
    {
        return exp;
    }
}
