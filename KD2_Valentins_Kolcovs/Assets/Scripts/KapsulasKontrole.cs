using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class KapsulasKontrole : MonoBehaviour
{
    public GameObject capsule;
    private Color customColor = new Color(0.0f, 0.0f, 0.0f);
    private int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        var renderer = capsule.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        if(i == 60)
        {
            customColor = new Color(UnityEngine.Random.Range(0.0f, 1.0f),UnityEngine.Random.Range(0.0f, 1.0f),UnityEngine.Random.Range(0.0f, 1.0f));
            GetComponent<Renderer>().material.SetColor("_Color", customColor);
            i = 0;
        }
    }
}
