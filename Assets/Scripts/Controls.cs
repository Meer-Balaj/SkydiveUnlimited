using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody), typeof(Collider))]
public class Controls: MonoBehaviour, IPointerMoveHandler
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _animator;

    [SerializeField] private float _moveSpeed;

    public void OnPointerMove(PointerEventData eventData)
    {
        
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed); //Stop y movement in rigidbody constraints

        /*if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
           // _animator.SetBool("isRunning", true);
        }
        else
        {
            //_animator.SetBool("isRunning", false);

        }*/
    }
}
