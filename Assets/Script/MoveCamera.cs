using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private float speed_camera;
    private void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-transform.right * speed_camera * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * speed_camera * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.up * speed_camera * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.up * speed_camera * Time.deltaTime);
        }
    }
}
