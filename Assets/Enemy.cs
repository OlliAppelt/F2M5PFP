using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private HealthComponent _healthComponent;

    private void Start()
    {
        _healthComponent = GetComponent<HealthComponent>();
    }

    public HealthComponent GetHealthComponent;
}
