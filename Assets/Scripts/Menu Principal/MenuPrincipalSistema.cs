using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalSistema : MonoBehaviour
{
    public string next;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame() {

        SceneManager.LoadScene(next);
    }

    public void Salir() {

        Application.Quit();
    }
}
