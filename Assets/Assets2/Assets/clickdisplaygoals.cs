using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class clickdisplaygoals : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text txt;
    public Button button;

    public Data data;
  public void Start()
    {
        
        button.onClick.AddListener(OnButtonClick);
    }

    public void OnButtonClick()
    {
        string listgoalsn = data.display();
        txt.text = listgoalsn;
        // Adicione aqui mais lógica que você deseja executar
    }
}
