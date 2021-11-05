using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] Image livesImage;
    public static int lives;
    [SerializeField] Sprite [] spriteArray;
    public Button play;

    // Start is called before the first frame update
    void Start()
    {
       
        lives = 3;
        livesImage.sprite = spriteArray[lives];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Comenzar()
    {
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

