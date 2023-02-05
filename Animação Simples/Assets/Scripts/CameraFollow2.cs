using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2 : MonoBehaviour
{
    public GameObject target;
    public float offsetX, offsetY, offsetZ;
    [Range(1,10)]
    public float smoothFactor;

    // Start is called before the first frame update
    void Start()
    {
        offsetX = 3.12f;
        offsetY = 3.94f;
        offsetZ = -3.25f;
        smoothFactor = 1.0f; 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.transform.position + new Vector3(offsetX, offsetY, offsetZ);
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor * Time.fixedDeltaTime);
        this.transform.position = smoothPosition;

    }
}
