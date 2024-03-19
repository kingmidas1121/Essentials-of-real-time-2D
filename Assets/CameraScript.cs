using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
      public Transform target;
    public Vector3 offset;
    public float distance = 5.0f;


    void Start()
    {

    }

    void Update()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.position - transform.forward * distance + offset;

            transform.position = targetPosition;

            transform.LookAt(target);
        }
    }
}
