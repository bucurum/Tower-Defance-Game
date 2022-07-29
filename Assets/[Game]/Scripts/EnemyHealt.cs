using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealt : MonoBehaviour
{
    [SerializeField] int maxHitPoint = 5;
    int currentHitPoint = 0;
    Enemy enemy;

    void OnEnable()
    {
        currentHitPoint = maxHitPoint;
    }

    void Start()
    {
        enemy = GetComponent<Enemy>();
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        currentHitPoint--;

        if (currentHitPoint <= 0)
        {
            gameObject.SetActive(false);
            enemy.RewardGold();
        }
    }
}
