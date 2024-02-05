using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMovement : MonoBehaviour
{
    public List<GameObject> wayPoints;
    private float speed = 5f;
    private int index = 0;
    void Update()
    {
        ObjectMovement();
        DestroyObject();
    }

    void ObjectMovement()
    {
        Vector3 target = wayPoints[index].transform.position;
        Vector3 position = transform.position;
        Vector3 movement = Vector3.MoveTowards(position, target, speed * Time.deltaTime);
        position = movement;
        transform.position = position;

        float distance = Vector3.Distance(position, target);

        if (distance <= 0.9)
        {
            index++;
        }
    }

    void DestroyObject()
    {
        if (index >= wayPoints.Count)
        {
            Destroy(gameObject);
        }
    }
}
