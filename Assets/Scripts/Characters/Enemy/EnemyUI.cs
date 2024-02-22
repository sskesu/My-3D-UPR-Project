using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyUI : MonoBehaviour
{
    [SerializeField] private Slider hpSlider;
    [SerializeField] private GameObject hpBar;

    private Health enemyHealth;

    private void Start()
    {
        enemyHealth = GetComponent<Health>();
        enemyHealth.OnDamage += UpdateUI;
        enemyHealth.OnDie += HpOff;
    }

    private void Update()
    {
        hpBar.transform.rotation = Camera.main.transform.rotation;
    }

    private void UpdateUI()
    {
        hpSlider.value = enemyHealth.HPSliderValue();
    }

    private void HpOff()
    {
        hpSlider.gameObject.SetActive(false);
    }
}
