using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SferasKontrole : MonoBehaviour
{
    public TextMeshProUGUI winText;

    // Start is called before the first frame update
    void Start()
    {
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Kapsula"))
        {
            winText.text = "Tu uzvarēji!";
        }
    }
}
