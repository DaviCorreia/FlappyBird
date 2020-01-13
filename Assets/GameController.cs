using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //varial da pontuação 
    public int Score;
    //variavel que sera manipulado para modificar
    public Text scoreText;
    //apos reiniciar a cena da om start chamado apenas uma vez ao iniciar 
    void Start()
    {
        Time.timeScale = 1;
    }
    //Apos o game over renicia a cena 
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
