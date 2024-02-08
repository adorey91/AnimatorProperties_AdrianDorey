using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;


    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !_animator.GetBool("InProgress"))
        {
            _animator.SetTrigger("Open/Close");
            _animator.SetBool("InProgress", true);
        }
    }

    public void OnOpenAnimationComplete()
    {
        _animator.SetBool("InProgress", false);
    }

    public void OnCloseAnimationComplete()
    {
        _animator.SetBool("InProgress", false);
    }

}
