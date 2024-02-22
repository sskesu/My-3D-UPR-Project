using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] public GameObject _player;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private List<Transform> spawnPos = new List<Transform>();

    private GameObject curEnemy;
    private Health enemyHealth;

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
        SetNewEnemy();
    }

    private void PopNewEnemy()
    {
        StartCoroutine(PopNewEnemyCo());
    }

    IEnumerator PopNewEnemyCo()
    {
        yield return new WaitForSeconds(2f);

        SetNewEnemy();
    }

    private void SetNewEnemy()
    {
        int rand = Random.Range(0, spawnPos.Count);
        curEnemy = Instantiate(enemyPrefab, spawnPos[rand]);
        enemyHealth = curEnemy.GetComponent<Health>();
        enemyHealth.OnDie += PopNewEnemy;
    }
}
