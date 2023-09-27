using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public int RotateSpeed;
    void Update()
    {
        transform.eulerAngles += new Vector3(0, RotateSpeed * Time.deltaTime, 0);
    }
}

