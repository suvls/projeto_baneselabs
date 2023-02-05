using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [Range(1, 10)]
    public float smoothFactor;

    [HideInInspector]
    public Vector3 minValue, maxValue;

    // Start is called before the first frame update
    void Start()
    {
        //offset = new Vector3(18.2f, 24.5f, 1.44f);
       // smoothFactor = 1f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 posicao = new Vector3(target.position.x, 0, 0f);
        Vector3 targetPosition = posicao + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor * Time.fixedDeltaTime);
        transform.position = smoothPosition;
        /*
        if (smoothPosition.x <= 0) 
        {
            smoothPosition = Vector3.Lerp(transform.position, new Vector3(0f, 0f, -1f), smoothFactor * Time.fixedDeltaTime);
            transform.position = smoothPosition;
        }

        if (smoothPosition.x >= 88)
        {
            smoothPosition = Vector3.Lerp(transform.position, new Vector3(88f, 0f, -1f), smoothFactor * Time.fixedDeltaTime);
            transform.position = smoothPosition;
        }
        else
        {
            transform.position = smoothPosition;
        }*/
    }
}
