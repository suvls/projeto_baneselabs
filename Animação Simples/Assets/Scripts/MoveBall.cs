using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float velocidade;
    public float deslocamentoVertical, deslocamentoHorizontal;
    public float verticalMin, verticalMax, horizontalMin, horizontalMax;
    public float salto;

    void Start()
    {
        horizontalMax = 14.5f;
        horizontalMin = -14.5f;
        verticalMax = 14.5f;
        verticalMin = -14.5f;
        this.transform.position = new Vector3(0, 0.5f, 0);

    }

    void Update()
    {
        deslocamentoVertical = Input.GetAxis("Vertical") * velocidade;
        deslocamentoVertical *= Time.deltaTime;

        Debug.Log(deslocamentoVertical);
    }
}
