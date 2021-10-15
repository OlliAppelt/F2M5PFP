using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInRangeChecker : MonoBehaviour
{
    [SerializeField] private float _radius;

    public Enemy GetFirstEnemyInRange()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, _radius);
        print(cols.Length);
        if (cols.Length <= 0)
        {
            return null;
        }

        return cols[0].GetComponent<Enemy>();
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, _radius);
    }
}
