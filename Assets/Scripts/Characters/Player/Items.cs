using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Items : MonoBehaviour
{
    public int maxPotion = 10;
    public int curPotion;
    public int potionHeal = 40;

    [SerializeField] private TMP_Text potionCount;

    private Health health;

    private void Start()
    {
        health = GameManager.Instance._player.GetComponent<Health>();
        curPotion = maxPotion;

        UpdateUI();
    }

    public void UsePotion()
    {
        if (curPotion <= 0)
            return;
        health.healHP(potionHeal);
        curPotion--;

        UpdateUI();
    }

    private void UpdateUI()
    {
        potionCount.text = curPotion.ToString();
    }
}
