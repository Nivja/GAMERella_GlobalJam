using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidetoSide : MonoBehaviour
{
    public Vector3 position1 = new Vector3(-2.46f, -2.67f, -1.5f);
    public Vector3 position2 = new Vector3(1, -2.3f, -1.5f);
    //these can be changed for each platform to go between x axis or y axis
    Vector3 currentTargetDestination;

    public float distanceTolerance = 0.5f;
    public float speed = 1;
    //1 is pretty good, but again we can increse and make it harder

    void Start()
    {
        transform.position = position1; 
        currentTargetDestination = position2;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentTargetDestination, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, currentTargetDestination) <= distanceTolerance)
        {

            if (currentTargetDestination == position1)
            {
                currentTargetDestination = position2;
            }
            else
            {
                currentTargetDestination = position1;
            }
        }
    }
}

