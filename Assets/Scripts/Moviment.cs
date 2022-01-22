using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    [SerializeField]float speed = 10f;
    [SerializeField]CircleCollider2D colisor;
    Rigidbody2D playerRB;
    Vector2 movimentPlayer;
    

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        //colisor = GetComponent<CircleCollider2D>();
    }

    void Update()
    {
        OnMove();
    }

    void OnMove()
    {
        movimentPlayer.x = Input.GetAxisRaw("Horizontal");
        movimentPlayer.y = Input.GetAxisRaw("Vertical");
        
        if (Input.GetKey(KeyCode.LeftControl))
        {
            speed = 5f;
            colisor.radius = 2;
        } else{
            speed = 10f;
            colisor.radius = 5;
        } 
    }

    void FixedUpdate() {
        playerRB.MovePosition(playerRB.position + movimentPlayer.normalized * speed * Time.fixedDeltaTime);
    }
}
