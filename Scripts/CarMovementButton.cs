using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementButton : MonoBehaviour {

    public Rigidbody car;
    private float speed = 20f;
    private float rotationSpeed = 50f;
    public static float xCoordinate;
    public static float zCoordinate;


    void Awake()
    {
        car = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        xCoordinate = car.transform.position.x;
        zCoordinate = car.transform.position.z;

        if (GameHandler.canMove)
        {
            car.transform.Translate(0, 0, -moveVertical * (Time.fixedDeltaTime * speed));
            car.transform.Rotate(0f, moveHorizontal * (Time.fixedDeltaTime * rotationSpeed), 0f);
        }

    }

}
