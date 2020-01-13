using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float Speed = 2f;
    private Rigidbody2D rig;

    public GameObject GameOver;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            rig.velocity = Vector2.up * Speed;
        }
    }
    // método para checar colisão
    private void OnCollisionEnter2D(Collision2D colisor)
    {
        GameOver.SetActive(true);
        // pausa o jogo
        Time.timeScale = 0;
    }

}
