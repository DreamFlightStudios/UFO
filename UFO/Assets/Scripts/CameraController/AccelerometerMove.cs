using System.Collections;
using UnityEngine;

public class AccelerometerMove : MonoBehaviour
{
    [SerializeField]private float speed;
    private Vector3 initialAcceleration;

    private void Start()
    {
        initialAcceleration = Input.acceleration;
    }

    private void Update()
    {
        AccelMove();
    }

    private void AccelMove()
    {
        /*Vector3 accel = Input.acceleration;

        GetComponent<Rigidbody>().velocity = new Vector3(accel.x, accel.y, accel.z) * speed;*/

        Vector3 currentAcceleration = Input.acceleration;
        Vector3 accelerationDelta = currentAcceleration - initialAcceleration;

        transform.position += accelerationDelta;
    }
}
