using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    public float health = 10f;
    public float damagePeriod = 1f;

    [SerializeField] private float defense = 0.5f;
    private float _delta = 0;
    void Update()
    {
        _delta += Time.deltaTime;
        if (_delta >= damagePeriod)
        {
            _delta = 0;
            OnDamaged(5f);
        }
    }
    public void OnDamaged(float damage)
    {
        health -= damage * (1 - defense);

        if (health <= 0)
            OnDeath();
    }

    void OnDeath()
    {
        Destroy(gameObject);
    }
}
