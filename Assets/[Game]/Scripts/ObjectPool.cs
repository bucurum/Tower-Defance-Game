using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] [Range(0.1f, 30f)] float spawnTimer = 1f;
    [SerializeField] [Range(0, 50)] int poolSize = 10;

    
    
    GameObject[] pool;
    public int enemyCount;
    bool isAllDead;
    
    private void Awake()
    {
        PopulatePool();
    }

    void Start()
    {   
        StartCoroutine(SpawnEnemy());
    }

    void PopulatePool()
    {
        pool = new GameObject[poolSize];
        enemyCount = pool.Length;

        for (int i = 0; i < pool.Length; i++)
        {
            pool[i] = Instantiate(enemyPrefab, transform);
            pool[i].SetActive(false);
        }
    }
    //todo wait for all enemies deactive, when every enemies deactive, active it all
    
    void EnableObjectInPool()
    {
            for (int i = 0; i < pool.Length; i++)
            {
                if(pool[i].activeInHierarchy == false)
                {
                    pool[i].SetActive(true); 
                    return;
                }
            }                 
    }
    public void waitForEveryEnemiesDie()
    {
        enemyCount--;
        if(enemyCount <= 0)
        {
            isAllDead = true;
        }else
        {
            isAllDead = false;
        }
    }
    
    IEnumerator SpawnEnemy()
    {
        if(isAllDead)
        {  
            for (int i = 0; i < poolSize; i++)
            {
                EnableObjectInPool();
                yield return new WaitForSeconds(spawnTimer);
            }
            
        }
        
    }
}
