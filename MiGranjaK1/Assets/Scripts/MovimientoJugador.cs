using UnityEngine;
using UnityEngine.InputSystem;



public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5f;
    public Rigidbody2D  rg; // abreviatura rigibody
    public Vector2 entrada;
    void Start()
    {
       rg = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
      rg.linearVelocity = entrada * velocidad;
        
    }

    public void Moverse(InputAction.CallbackContext contexto){ 
        entrada = contexto.ReadValue<Vector2>();
}

    }