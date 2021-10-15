using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyInRangeChecker))]
public class Tower : MonoBehaviour
{
    [SerializeField] private Transform _turret;
    private EnemyInRangeChecker _enemyInRangeChecker;

    private void Start()
    {
        _enemyInRangeChecker = GetComponent<EnemyInRangeChecker>();    }

    private void Update()
    {
        Enemy enemy = _enemyInRangeChecker.GetFirstEnemyInRange();
        if (enemy != null)
        {
            _turret.LookAt(enemy.transform);
        }
    }
}
