using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private Slider hpSlider;
    private Health playerHealth;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

    }

    private void Start()
    {
        playerHealth = GameManager.Instance._player.GetComponent<Health>();
    }

    public void UpdateUI()
    {
        hpSlider.value = playerHealth.HPSliderValue();
    }
}
