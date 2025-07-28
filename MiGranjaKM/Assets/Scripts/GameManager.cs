using UnityEngine;

public class GameManager : MonoBehaviour
{
   public int ConteoHuevos;
    public static GameManager instancia;
    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    public void SumarHuevo()
    {
        ConteoHuevos++;
        Debug.Log("ConteoHuevos");
    }


        // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
