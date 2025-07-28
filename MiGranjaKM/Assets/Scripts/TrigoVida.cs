using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
public class TrigoVida : MonoBehaviour
{
    int estado = 0;
    Animator animator;
    float tiempo = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(CambiarEstado());
    }

    private IEnumerator CambiarEstado()
    {
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
