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


    // Start is called before the first frame update
    void Start()
    {   
        enemyCount = poolSize;
        StartCoroutine(EnableObjectInPool());
        SpawnEnemy();
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
    //todo wait for all enemies deactive, when every enemies deactive, active it all
    
    IEnumerator EnableObjectInPool()
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
    public void waitForEveryEnemiesDie()
    {
        Debug.Log("hello you are in waitforeveryenemiesdie funciton");
        enemyCount -= enemyCount;
        if(enemyCount <= 0)
        {
            Debug.Log("all enemies die");
            isAllDead = true;
        }else
        {
            Debug.Log("enemies still alive");
            isAllDead = false;        
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
