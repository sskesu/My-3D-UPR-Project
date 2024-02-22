using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyUI : MonoBehaviour
{
    [SerializeField] private Slider hpSlider;

    private Health enemyHealth;

    private void Start()
    {
        enemyHealth = GetComponent<Health>();
        enemyHealth.OnDamage += UpdateUI;
    }

    public void UpdateUI()
    {
        hpSlider.value = enemyHealth.HPSliderValue();
    }
}
