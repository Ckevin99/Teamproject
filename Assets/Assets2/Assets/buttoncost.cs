using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;

public class buttoncost: MonoBehaviour
{
    public TMP_Text TxT;
    public Button button;
    public scene2data datas;

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
        var crossdata = datas.data;
        TxT.text = $"Points :{crossdata.points}";
        crossdata.points -= some_points;
        // Adicione aqui mais lógica que você deseja executar
    }
}
