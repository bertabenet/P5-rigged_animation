using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int rotationSpeed;
    public Transform point;

    private int angle;
    private Vector3 axis;

    // Start is called before the first frame update

    void Start()
    {
        angle = 0;
        axis = new Vector3(0, -1, 0);

        InvokeRepeating("increaseAngle", 0.01f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //angle += rotationSpeed;
        // 8000
        if(angle >= 180)
        {
            axis = new Vector3(0, -axis.y, 0);
            angle = 0;
        }
        transform.RotateAround(point.position, axis, rotationSpeed * Time.deltaTime);
        
    }

    void increaseAngle()
    {
        angle += rotationSpeed;
    }
    //transform.RotateAround(axis.position, new Vector3(0, 1, 0), rotationSpeed * Time.deltaTime);
}

