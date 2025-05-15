using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    [SerializeField] private float movespeed = 2f;

    private PlayerController playercontroller;
    private Vector2 moment;
    private Rigidbody2D rb;

    private void Awake()
    {
        playercontroller = new PlayerController();
        rb = GetComponent<Rigidbody2D>();
    }


    private void OnEnable()
    {
        playercontroller.Enable();
    }

    private void Update()
    {
        PlayerInput();
    }

    private void FixedUpdate()
    {
        Move();
    }


    private void PlayerInput()
    {
        moment = playercontroller.Moment.Move.ReadValue<Vector2>();
    }

    private void Move()
    {
        rb.MovePosition(rb.position + moment * (movespeed * Time.deltaTime));
    }
}
