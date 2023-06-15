using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Living
{

    public HUD hud;
    private Animator animator;
    private CapsuleCollider interactCollider;
    private Rigidbody rigidBody;
    private Vector3 velocity;

    private void OnMove(InputValue value)
    {
        // キーボードやスティックによる2方向の入力を受け取る
        var axis = value.Get<Vector2>();

        if (axis != Vector2.zero)
        {
            animator.speed = 1;
            animator.SetFloat("X", axis.x);
            animator.SetFloat("Y", axis.y);
        } else
        {
            animator.Play(0);
            animator.speed = 0;
        }

        velocity = new Vector3(axis.x, 0, axis.y);

    }

    private void OnInteract(InputValue value)
    {
        RaycastHit[] hits = Physics.SphereCastAll(
            transform.position,
            0.2f,
            Vector3.forward
        );

        foreach (var hit in hits)
        {
            if (hit.collider.GetComponent<Citizen>() != null)
            {
                var citizen = hit.collider.GetComponent<Citizen>();
                citizen.interact();
            }
        }

    }

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetFloat("X", 0);
        animator.SetFloat("Y", 0);

        interactCollider = GetComponent<CapsuleCollider>();

        rigidBody = GetComponent<Rigidbody>();

        hud.OnPlayerHPChanged(this.hp);
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.velocity = velocity * 1.0f;
    }

}
