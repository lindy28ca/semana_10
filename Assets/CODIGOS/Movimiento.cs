using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    Transform posicion;
    SpriteRenderer cambio;
    public int velocidad;
    public int xdireccion=1;
    public int ydireccion=1;
    void Awake()
    {
        posicion = GetComponent<Transform>();
        cambio = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        transform.position = new Vector2(posicion.position.x + velocidad * xdireccion * Time.deltaTime, posicion.position.y);
        if (posicion.position.x >= 8.21)
        {
            if (cambio.flipX == true)
            {
                cambio.flipX = false;
                cambio.flipY = false;
            }
            else
            {
                cambio.flipX = true;
                cambio.flipY = true;
            }

            xdireccion = -1;
        }
        if (posicion.position.x <= -8.21)
        {
            if (cambio.flipX == true)
            {
                cambio.flipX = false;
                cambio.flipY = false;
            }
            else
            {
                cambio.flipX = true;
                cambio.flipY = true;
            }
            xdireccion = 1;
        }
        transform.position = new Vector2(posicion.position.x,posicion.position.y+velocidad*ydireccion*Time.deltaTime);
        if(posicion.position.y>= 3.98)
        {
            if (cambio.flipX == true)
            {
                cambio.flipX = false;
                cambio.flipY = false;
            }
            else
            {
                cambio.flipX = true;
                cambio.flipY = true;
            }
            ydireccion = -1;
        }
        if (posicion.position.y <= -3.98)
        {
            if (cambio.flipX == true)
            {
                cambio.flipX = false;
                cambio.flipY = false;
            }
            else
            {
                cambio.flipX = true;
                cambio.flipY = true;
            }
            ydireccion = 1;
        }
    }
}
