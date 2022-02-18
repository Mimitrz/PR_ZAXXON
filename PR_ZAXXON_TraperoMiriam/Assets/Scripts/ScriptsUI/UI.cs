using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] Text scoreTx;

    // Start is called before the first frame update
    void Start()
    {
        scoreTx.text =GameManager.globalScore.ToString();
      
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

   
    public void Comenzar()
    {
        
         SceneManager.LoadScene(1);

    }
    
    public void Ajustes()
    {
        SceneManager.LoadScene(2);

    } 
    
    public void HighScores()
    {
        SceneManager.LoadScene(4);

    }
    
    public void Reanudar()
    {
        SceneManager.LoadScene(1);

    }
    
    public void Menu()
    {
        SceneManager.LoadScene(0);

    }
    
    
    public void Salir()
    {
        //para que salga al escritorio del pc una vez se compile el juego
        Application.Quit();
    } 
}

