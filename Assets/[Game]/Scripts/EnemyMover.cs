using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<WayPoint> path = new List<WayPoint>();
    [SerializeField] [Range(0,5f)] float speed = 1f;
    Enemy enemy;
    ObjectPool objectPool;

    void OnEnable()
    {
        FindPath();
        ReturnToStart();
        StartCoroutine(PrintWaypointName());     
    }
    void Start()
    {
        enemy = GetComponent<Enemy>();
    }

    void FindPath()
    {
        path.Clear();
        
        GameObject parent = GameObject.FindGameObjectWithTag("Path");

        foreach (Transform child in parent.transform)
        {
            WayPoint wayPoint = child.GetComponent<WayPoint>();
            if (wayPoint != null)
            {
                path.Add(wayPoint);    
            }
            
        }
    }
    void FinishPath()
    {
        gameObject.SetActive(false);
        enemy.StealGold();
        objectPool.enemyCount--;
    }

    IEnumerator PrintWaypointName()
    {
       
        foreach (WayPoint waypoint in path)
        {
             Vector3 startPosition = transform.position;
             Vector3 endPosition = waypoint.transform.position;
             float travelPercent = 0f;
             transform.LookAt(endPosition);

            while (travelPercent < 1f)
            {
                travelPercent += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(startPosition, endPosition, travelPercent);
                yield return new WaitForEndOfFrame();
            }
        }
        
        FinishPath();
    }
    void ReturnToStart()
    {
        transform.position = path[0].transform.position;
    }

}
