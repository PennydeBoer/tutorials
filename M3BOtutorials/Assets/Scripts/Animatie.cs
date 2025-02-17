using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatie : MonoBehaviour
{
    Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnMouseDown()
    {
        _animator.SetTrigger("click");
    }
    private void OnMouseUp()
    {
        _animator.ResetTrigger("click");
    }
}
