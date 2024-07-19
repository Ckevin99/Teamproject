using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class click : MonoBehaviour
{
    public TMP_Text ButtonTxT;
    public Button button;

    public void Start()
    {
        Debug.Log("ButtonTxT: " + ButtonTxT);
        Debug.Log("button: " + button);
        button.onClick.AddListener(OnButtonClick);
    }

    public void OnButtonClick()
    {
        ButtonTxT.text = "Botão Pressionado!";
        // Adicione aqui mais lógica que você deseja executar
    }
}
