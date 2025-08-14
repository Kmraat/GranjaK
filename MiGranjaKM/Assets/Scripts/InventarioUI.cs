using UnityEngine;
using UnityEngine.UIElements;

public class InventarioUI : MonoBehaviour
{
    private Label labelHuevos;
    private int huevosPrevios = -1;
    
    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        labelHuevos = root.Q<Label>("ultimo conocido");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instancia.ConteoHuevos != huevosPrevios)
        {
            huevosPrevios = GameManager.instancia.ConteoHuevos;
            labelHuevos.text = huevosPrevios.ToString();

        }
    }
}
