using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocator : MonoBehaviour
{
    [SerializeField] Transform weapon;
    [SerializeField] float towerRange = 15f;
    [SerializeField] ParticleSystem projectileParticleSystem;
    Transform target;
    // Update is called once per frame
    void Update()
    {
        FindClosestTarget();
        AimWeapon();
    }

    void FindClosestTarget()
    {
        Enemy[] enemies = FindObjectsOfType<Enemy>();
        Transform closestTarget = null;
        float MaxDistance = Mathf.Infinity;

        foreach (Enemy enemy in enemies)
        {
            float targetDistance = Vector3.Distance(transform.position, enemy.transform.position);

            if (targetDistance < MaxDistance)
            {
                closestTarget = enemy.transform;
                MaxDistance = targetDistance;
            }
        }
        target = closestTarget;
    }

    private void AimWeapon()
    {
        if (target == null)
        {
            return;
        }
        float targetDistance = Vector3.Distance(transform.position, target.position);
        weapon.LookAt(target);

        if(targetDistance<towerRange && target != null)
        {
            Attack(true);
        }else
        {
            Attack(false);
        }
    }
    void Attack(bool IsActive)
    {
        var emissionModule = projectileParticleSystem.emission;
        emissionModule.enabled = IsActive;
    }
}
