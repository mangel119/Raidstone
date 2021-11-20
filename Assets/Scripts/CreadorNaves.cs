using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorNaves : MonoBehaviour
{
    public GameObject Nave1;
    public float tiempoCreacion=2f;
    public float rangoCreacion=2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Creando1",0.0f,tiempoCreacion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Creando1()
    {
        Vector3 SpawnPosition = new Vector3 (2,16,17);
        SpawnPosition = this.transform.position + Random.onUnitSphere * rangoCreacion;
        SpawnPosition = new Vector3 (SpawnPosition.x,SpawnPosition.y,100);

        GameObject Naveuno = Instantiate (Nave1,SpawnPosition,Quaternion.identity);
    }
}
