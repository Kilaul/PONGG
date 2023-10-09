using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPala : MonoBehaviour
{
    public float velocidad;
    public bool jugadorB;

    void Update()
    {
        float vertical = 0;
        float horizontal = 0;

        if (jugadorB)
        {
            vertical = Input.GetAxis("Vertical B");
            horizontal = Input.GetAxis("Horizontal B");
        }
        else
        {
            vertical = Input.GetAxis("Vertical A");
            horizontal = Input.GetAxis("Horizontal A");
        }

        transform.position = transform.position + new Vector3(horizontal, vertical, 0) * velocidad * Time.deltaTime;
    }

}