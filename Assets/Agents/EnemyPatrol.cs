using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrol : MonoBehaviour
{
    private NavMeshAgent enemy;
    public Transform[] waypoints;
    int waypointindex;
    Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        UpdateDestincation();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, target) <1)
        {
            Iteratewaypointindex();
            UpdateDestincation();
        }
    }

    void UpdateDestincation()
    {
        target = waypoints[waypointindex].position;
        enemy.SetDestination(target);
    }

    void Iteratewaypointindex()
    {
        waypointindex++;
        if(waypointindex == waypoints.Length)
        {
            waypointindex = 0;
        }
    }
}
