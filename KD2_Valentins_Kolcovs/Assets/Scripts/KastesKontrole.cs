using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KastesKontrole : MonoBehaviour
{
    public float rotation_speed = 0.5f;
    private float verMove = 0.0f;
    private float horMove = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        horMove = Input.GetAxis("Horizontal");
        verMove = Input.GetAxis("Vertical");
        transform.Rotate(new Vector3(horMove, 0.0f, verMove)*rotation_speed);
    }
}
