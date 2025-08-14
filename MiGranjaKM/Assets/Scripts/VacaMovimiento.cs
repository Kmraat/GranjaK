using System;
using UnityEngine;

public class VacaMovimiento : MonoBehaviour
{
    public Transform areaMovimiento;
    public float velocidad = 1f;
    private Vector2 destino;
    public SpriteRenderer sr;
    Vector2 posicionActual;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        NuevoDestino();
        posicionActual = transform.position;
        Debug.Log(posicionActual + " | " + destino);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, destino, velocidad * Time.deltaTime);

        Vector2 direccion = posicionActual - destino;
        Debug.Log("Direccion" + direccion);

        if (direccion.x >= 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }


        if (Vector2.Distance(transform.position, destino) < 0.1f)
        {
            NuevoDestino();
            posicionActual = transform.position;
            Debug.Log(posicionActual + " | " + destino);
        }
    }

    void NuevoDestino()
    {
        Vector2 centro = areaMovimiento.position;
        Vector2 tama�o = areaMovimiento.localScale;

        float x = UnityEngine.Random.Range(centro.x - tama�o.x / 2f, centro.x + tama�o.x / 2f);
        float y = UnityEngine.Random.Range(centro.y - tama�o.y / 2f, centro.y + tama�o.y / 2f);

        destino = new Vector2(x, y);

        Debug.Log(destino);
    }
}
