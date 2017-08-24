using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float speed;

    private Transform target;

    private int wavepointIndex = 0;

    private float distanceDifferenceBetweenPoints = 0.4f;

    private void Start()
    {
        target = WaypointController.points[0];

    }

    void Update()
    {
        Vector3 direction = target.position - transform.position;

        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        /*time deltatime assures that the speed is not related with the framerate of your computer
         La longitud del vector (modulo) al multiplicarlo por speed, el bicho avanzará esa distancia tantas veces
         como la speed diga. Para que vaya mejor, usar direction.normalized, que te dará el vector en 1 "metro"/"coso". 
         */

        if (Vector3.Distance(transform.position, target.position) <= distanceDifferenceBetweenPoints )
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint() {

        int waypointsArrayLenght = WaypointController.points.Length - 1;

        if (wavepointIndex >= waypointsArrayLenght)
        {
            Destroy(gameObject);
            return;
        }

        wavepointIndex++;

        target = WaypointController.points[wavepointIndex];

    }
}
