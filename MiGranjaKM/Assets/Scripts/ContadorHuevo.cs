using UnityEngine;
using UnityEngine.UIElements;
public class ConteoHuevos : MonoBehaviour
{
    private Label labelHuevos;
    private int huevosAntes = -1;

    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        labelHuevos = root.Q<Label>("labelHuevos");
    }
   

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instancia.ConteoHuevos != huevosAntes)
        {
            huevosAntes = GameManager.instancia.ConteoHuevos;
            labelHuevos.text = $"Huevo: {huevosAntes}";
        }
    }
}
