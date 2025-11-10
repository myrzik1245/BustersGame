using System;
using UnityEngine;

public class HealthStat
{
    private int _maxHealth;

    public HealthStat(int maxHealth, int startHealth)
    {
        _maxHealth = maxHealth;
        Health = startHealth;
    }

    public int Health { get; private set; }

    public void TakeDamage(int damage)
    {
        if (damage < 0)
            Debug.LogError($"Damage < 0 ({damage})");

        Health = Math.Clamp(Health - damage, 0, _maxHealth);
    }

    public void Heal(int healAmount)
    {
        if (healAmount < 0)
            Debug.LogError($"Heal < 0 ({healAmount})");

        Health = Math.Clamp(Health + healAmount, 0, _maxHealth);
    }
}
