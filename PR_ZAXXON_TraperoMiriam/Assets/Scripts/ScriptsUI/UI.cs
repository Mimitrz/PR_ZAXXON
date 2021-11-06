using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Comenzar()
    {
        ConfigVars.numLives = 3;
        SceneManager.LoadScene(1);

    }
    public void Salir()
    {
        

    } 
    public void Ajustes()
    {
        SceneManager.LoadScene(2);

    }


}

