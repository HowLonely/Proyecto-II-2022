using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraQueTeSigue : MonoBehaviour
{
    //target es lo que queremos seguir con la camara
    public Transform target;
    public Vector3 offset;
    //variables que permiten ponerle limites a la camara
    //por ejemplo, en el eje x, el limite bajo seria hasta donde quieres que se pueda mover la cam a la izquierda

    public Vector3 LimiteBajo, LimiteAlto;

    private void FixedUpdate()
    {
        Seguimiento();
    }

    void Seguimiento() {
        Vector3 targetPosicion = target.position + offset;
        //Mathf.Clamp hace que la camara no pueda moverse mas alla de las variables limites
        //los limites hay que ponerlos en el unity
        Vector3 camaraLimitada = new Vector3(Mathf.Clamp(targetPosicion.x,LimiteBajo.x,LimiteAlto.x),Mathf.Clamp(targetPosicion.y,LimiteBajo.y,LimiteAlto.y),Mathf.Clamp(targetPosicion.z,LimiteBajo.z,LimiteAlto.z)); 
        transform.position = camaraLimitada;
    }
}
