using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        transform.position = new Vector3(0,0,0);
    }
}
