using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    private int health;
    public event Action OnDie;
    public event Action OnDamage;

    public bool IsDead => health == 0;

    private void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        if (health == 0) return;
        health = Mathf.Max(health - damage, 0);

        if (health == 0)
            OnDie?.Invoke();

        OnDamage?.Invoke();
    }

    public float HPSliderValue()
    {
        return (float)health / maxHealth;
    }

    public void healHP(int heal)
    {
        health = Mathf.Min(health + heal, maxHealth);
        OnDamage?.Invoke();
    }
}