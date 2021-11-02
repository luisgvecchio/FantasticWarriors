using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Transform target;

    float enemySpeed = 6f;

    float aggroRange = 5f;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(2 * transform.position - target.position);

        Vector3 distance = target.position - transform.position;

        float distanceToPlayer = distance.magnitude;
        float step = enemySpeed * Time.deltaTime;

        if (distanceToPlayer < aggroRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }
}
