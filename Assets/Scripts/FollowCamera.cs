using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public float cameraHeigh;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position - transform.forward * cameraHeigh;
    }
}
