using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1f;

    public float rotateSpeed = 100f;

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        float v = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(0, 0, v);

        velocity = transform.TransformDirection(velocity);

        transform.localPosition += velocity * speed * Time.fixedDeltaTime;

        transform.Rotate(0, h * rotateSpeed * Time.fixedDeltaTime, 0);

        if (v > 0)
        {
            animator.SetBool("Walk", true);
        }
        else if (v < 0)
        {
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
    }
}