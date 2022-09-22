using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] [Range(0.1f, 30f)] float spawnTimer = 1f;
    [SerializeField] [Range(0, 50)] public int poolSize = 10;

    public static int enemyCount = 10;
    
    GameObject[] pool;
   
    
    private void Awake()
    {
        PopulatePool();
    }


    // Start is called before the first frame update
    void Start()
    {   
        enemyCount = poolSize;
        StartCoroutine(EnableObjectInPool());
        SpawnEnemy();
    }
    void Update()
    {
        Debug.Log("enemyCount: " + enemyCount);
        if(enemyCount <= 0)
        {
            Debug.Log("all enemies die");
            StartCoroutine(EnableObjectInPool());
            SpawnEnemy();
            enemyCount = poolSize;
        }else
        {
            Debug.Log("still alive enemy left");   
        }
    }


    void PopulatePool()
    {
        pool = new GameObject[poolSize];

        for (int i = 0; i < pool.Length; i++)
        {
            pool[i] = Instantiate(enemyPrefab, transform);
            pool[i].SetActive(false);
        }
    }
    
    public IEnumerator EnableObjectInPool()
    {      
        foreach (var element in pool)
        {
            if(element.activeInHierarchy == false)
            {
                element.SetActive(true);
                yield return new WaitForSeconds(spawnTimer);
            } 
        }           
    }
  
    
    void SpawnEnemy()
    {
        for(int i = 0 ; i < poolSize ; i++)
        {
            EnableObjectInPool();  
        }   
    }
}
