using UnityEngine;
using UnityEngine.EventSystems; // Importe o namespace para EventSystems

public class testclick : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Botão foi pressionado!");
        // Adicione aqui mais lógica que você deseja executar
    }
}