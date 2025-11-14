using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Sta")]
public class Stats : ScriptableObject
{
    [Header("Start Stats")]
    [SerializeField]
    private int baseHealth;
    public int maxHealth;
    [SerializeField] 
    private int healthGrown;
    [SerializeField]
    public int level;
    [SerializeField]
    public int experienceToLevelUp = 150;
    // Experience needed to level up : exp(L) = level^2 * 50 + 100*level
    public void UpdateStats()
    {
        maxHealth = baseHealth + healthGrown * (int)Math.Pow(level, 1.5);
        experienceToLevelUp = level * level * 50 + 100 * level;
    }    

    // Start is called before the first frame update

}
