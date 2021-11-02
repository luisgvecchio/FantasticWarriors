using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Transform target;

    float enemySpeed = 6f;

    float aggroRange = 5f;

    Transform eyes; 

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

        eyes = GameObject.Find("Enemy/Eyes").transform;
    }

    // Update is called once per frame
    void Update()
    {
        

        Vector3 distance = target.position - transform.position;

        float distanceToPlayer = distance.magnitude;
        float step = enemySpeed * Time.deltaTime;

        if (distanceToPlayer < aggroRange)
        {
            transform.LookAt(2 * transform.position - target.position);
            eyes.transform.localScale = new Vector3(0.4f, 0.4f, 0.1f);
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        else
        {
            eyes.transform.localScale = new Vector3(0.25f, 0.25f, 0.1f);
        }
    }
}
