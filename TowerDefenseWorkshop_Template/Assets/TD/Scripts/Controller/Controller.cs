using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] float _speed = 5.0f;
    [SerializeField] float _speedZoom = 5.0f;
    [SerializeField] Camera _camera = null;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.position = transform.position + new Vector3(horizontalInput * _speed * Time.deltaTime, 0, verticalInput * _speed * Time.deltaTime);

        float mouseWheelInput = Input.GetAxis("Mouse ScrollWheel");
        _camera.transform.position = _camera.transform.position + _camera.transform.forward * mouseWheelInput * _speedZoom * Time.deltaTime;
    }
}
