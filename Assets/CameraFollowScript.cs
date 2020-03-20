using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{

    public Transform target;
    public float smoothSpeed;
    public Vector3 offset;


    void Update()
    {
        //Vector3 desiredPosition = target.position + offset;
        Vector3 desiredPosition = new Vector3(target.position.x + offset.x, offset.y, target.position.z + offset.z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
