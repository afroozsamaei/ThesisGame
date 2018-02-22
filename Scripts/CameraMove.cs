using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public Rigidbody topCamera;
    public GameObject player;
    private float speed = 60f;

    void Awake()
    {
        topCamera = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (GameHandler.cameraMove)
        {

            topCamera.transform.Translate(-moveHorizontal * (Time.fixedDeltaTime * speed), 0, -moveVertical * (Time.fixedDeltaTime * speed));
        }

    }
}
