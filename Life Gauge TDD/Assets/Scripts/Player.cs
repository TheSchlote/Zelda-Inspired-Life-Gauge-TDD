using System;
using UnityEngine;

public class Player
{
    public int CurrentHealth { get; private set; }
    public int MaximumHealth { get; private set; }

    public Player (int currentHealth, int maximumHealth = 12)
    {
        if (currentHealth < 0) throw new ArgumentOutOfRangeException("currentHealth");
        if (currentHealth > maximumHealth) throw new ArgumentOutOfRangeException("currentHealth");
        CurrentHealth = currentHealth;
        MaximumHealth = maximumHealth;
    }

    public void Heal(int amount)
    {
        CurrentHealth = Mathf.Min(CurrentHealth + amount, MaximumHealth);
    }

    public void Damage(int amount)
    {
        CurrentHealth = Mathf.Max(CurrentHealth - amount, 0);
    }
}
