using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SumaYResultado : MonoBehaviour
{

    public TMP_InputField Num1;
    public TMP_InputField Num2;
    public TextMeshProUGUI Total;
    int Number1;
    int Number2;

    // Start is called before the first frame update
    void Start()
    {
        Total.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Calcular()
    {
        Number1 = int.Parse(Num1.text);
        Number2 = int.Parse(Num2.text);

        Total.text = $"{Number1 + Number2}";
    }
}
