using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatie2 : MonoBehaviour
{
    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            _animator.SetTrigger("walk");
            _animator.ResetTrigger("idle");
            _animator.ResetTrigger("walkR");
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            _animator.ResetTrigger("walk");
            _animator.ResetTrigger("idle");
            _animator.SetTrigger("walkR");
        }
        else
        {
            _animator.ResetTrigger("walk");
            _animator.SetTrigger("idle");
            _animator.ResetTrigger("walkR");
        }
    }
}
