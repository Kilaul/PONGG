using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public float velocidad;
    public Vector2 direccion;
    public Puntuacion punt;
    private void Start()
    {
        Spawn();
    }

    void Update()
    {
        transform.position = transform.position + (Vector3)direccion * velocidad * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Vertical")
        {
            direccion = new Vector2(-direccion.x, direccion.y);
        }
        if (collision.gameObject.tag == "Horizontal")
        {
            direccion = new Vector2(direccion.x, -direccion.y);
        }
        if (collision.gameObject.tag == "Porteria A")
        {
            Debug.Log("He entrado en la Portería A");
            punt.puntuacionA = punt.puntuacionA + 1;
            Spawn();
        }
        if (collision.gameObject.tag == "Porteria B")
        {
            Debug.Log("He entrado en la Portería B");
            punt.puntuacionB = punt.puntuacionB + 1;
            Spawn();
        }
    }

    void Spawn()
    {
        transform.position = new Vector3(0, 0);
        float x = Random.Range(-1f, 1f);
        if(x > 0)
        {
            x = 1;
        }
        else
        {
            x = -1;
        }
        float y = Random.Range(-1f, 1f);
        direccion = new Vector2 (x, y);
    }
}
