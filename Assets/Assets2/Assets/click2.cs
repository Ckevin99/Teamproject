using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;

public class click2 : MonoBehaviour
{
    public Text TxT;
    public Button button;
    public Data data;

    int some_points = 0;

    public void Start()
    {
        Debug.Log("ButtonTxT: " + TxT);
        Debug.Log("button: " + button);
        button.onClick.AddListener(OnButtonClick);
        some_points = 10;
    }

    public void OnButtonClick()
    {
        TxT.text = "Changed";
        data.points += some_points;
        // Adicione aqui mais lógica que você deseja executar
    }
}
