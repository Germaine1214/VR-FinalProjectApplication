using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingAnimation : MonoBehaviour
{
    public Animator animator;
    public float moveSpeed = 1f;

    private void Update()
    {
        // Move the object forwards
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    private void Start()
    {
        // Enable animation looping
        if (animator != null)
        {
            animator.SetBool("Loop", true);
        }
    }
}
