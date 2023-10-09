using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10;
    Rigidbody2D rb;

    [SerializeField] InputAction PlayerMove;
    Vector2 movementInput;

    private void OnEnable()
    {
        PlayerMove.Enable();
    }
    private void OnDisable()
    {
        PlayerMove.Disable();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        movementInput = PlayerMove.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.velocity = movementInput * moveSpeed;
    }
}
