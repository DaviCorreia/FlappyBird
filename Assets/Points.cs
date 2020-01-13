using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GameController GameController;
    void Start()
    {
        GameController = FindObjectOfType<GameController>();  
    }
    // método que adiciona a pontuação ao passar no colisor

    void OnTriggerEnter2D(Collider2D colisor)
    {
        // quando o personagem bater no colisor entre os canos é adicionado 
        //1 ponto a pontuação geral do jogo 
        //e vai modificar o texto na cena para receber o valor
        GameController.Score++;
        GameController.scoreText.text = GameController.Score.ToString();
    }

}
