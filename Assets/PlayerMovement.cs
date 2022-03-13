using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody = default;
    //[SerializeField] private int _playerVelocity = default;
    
    
    private Vector2 inputDirection;
    private Vector3 rotationSpeed = new Vector3(0, 50, 0);
    private float movementSpeed = 7;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        Vector2 inputs = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        inputDirection = inputs.normalized;

        if (Input.GetKeyDown(KeyCode.S))
        {
            movementSpeed = 4;
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            movementSpeed = 7;
        }
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            StartCoroutine(contador());
        }

        
    
    }

    private void FixedUpdate()
    {
        
            Quaternion deltaRotation = Quaternion.Euler(Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.deltaTime);
            _rigidbody.MoveRotation(_rigidbody.rotation * deltaRotation);
            _rigidbody.MovePosition(_rigidbody.position + transform.forward * movementSpeed * inputDirection.y * Time.deltaTime);

    }
    IEnumerator contador()
    {
        movementSpeed = 15;
        yield return new WaitForSeconds(1.5f);
        movementSpeed = 7;
        //yield return new WaitForSeconds(2f);

    }

}
