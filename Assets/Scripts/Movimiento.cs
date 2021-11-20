using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private float speed=3f;
    public Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        dir = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= dir * speed * Time.deltaTime;
    }
}
