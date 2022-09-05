using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyHealt : MonoBehaviour
{
    [SerializeField] int maxHitPoint = 5;

    [Tooltip("Add amount to maxHitPoint when enemy dies")]
    [SerializeField] int difficultyRamp = 6;
    int currentHitPoint = 0;
    Enemy enemy;
    ObjectPool objectPool;

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

    void ProcessHit()
    {
        currentHitPoint--;

        if (currentHitPoint <= 0)
        { 
            gameObject.SetActive(false);
            maxHitPoint += difficultyRamp;
            enemy.RewardGold();
            objectPool.enemyCount--;
            
        }
    }
}
