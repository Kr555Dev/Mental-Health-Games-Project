using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateScript : MonoBehaviour
{
    // Move object using accelerometer
    [SerializeField]
    public float speed = 10.0f;
    [SerializeField]
    public Transform platf;
    public float rotation;
    void Start()
    {
          
    }
    void FixedUpdate()
    {
        Vector3 dir = Vector3.zero;

        // remap device acceleration axis to game coordinates:
        //  1) XY plane of the device is mapped onto XZ plane
        //  2) rotated 90 degrees around Y axis
        dir.z = -Input.acceleration.x;  // -> these for potraite mode.
        // dir.z = Input.acceleration.x;

        // clamp acceleration vector to unit sphere
        if (dir.sqrMagnitude > 1)
            {dir.Normalize(); }

        // Make it move 10 meters per second instead of 10 meters per frame...
        dir *= Time.deltaTime;

        // Move object
        transform.Rotate(dir * speed);

        //rotation = transform.rotation.z;
        //var rot = transform.localEulerAngles;
        //rot.z = rotation;
        //transform.localEulerAngles = rot;
        //rotation = Mathf.Clamp(rotation, 90, -90);
    }

    //public void LeftRotate()
    //{
    //    Debug.Log("press");
    //    platf.Rotate(0f, 0f, speed * Time.deltaTime);
    //}

    //public void RightRotate() 
    //{
    //    Debug.Log("press");
    //    platf.Rotate(0f, 0f, -speed * Time.deltaTime);
    //}































    // Rigidbody rb;
    // float dirx;
    // public float rotatespeed = 10f;
    // Vector3 currentEulerAngles;
    // public Transform Platform;

    //void Start()
    //{
    //    // rb = GetComponent<Rigidbody>(); 
    //}

    //void Update()
    //{
    //    //dirx = Input.acceleration.z * rotatespeed;
    //    //currentEulerAngles += new Vector3(0f, 0f, 1f) * Time.deltaTime * rotatespeed;
    //    //transform.eulerAngles = currentEulerAngles;
    //}

    //void FixedUpdate()
    //{

    //}

    //public void LeftButton()
    //{
    //    Debug.Log("press");
    //    Platform.Rotate(0f, 0f, rotatespeed * Time.deltaTime);
    //}




























    //private Rigidbody rb;
    //public float dirx;
    //public float speed = 100f;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    Vector3 dir = Vector3.zero;
    //    dir = Input.acceleration * speed;
    //    dir *= Time.deltaTime;

    //    transform.Rotate(0f, 0f, speed * Time.deltaTime);

    //    if (Input.GetKey("w"))
    //    {
    //        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    //    }
    //}
    //Vector3 dir = Vector3.zero;



    //// remap device acceleration axis to game coordinates:
    ////  1) XY plane of the device is mapped onto XZ plane
    ////  2) rotated 90 degrees around Y axis
    //dir.z = -Input.acceleration.y;
    //    //dir.x = Input.acceleration.z;

    //    // clamp acceleration vector to unit sphere
    //    if (dir.sqrMagnitude > 1)
    //        dir.Normalize();
    //    dir *= Time.deltaTime;

    //    // Move object
    //    transform.Rotate(0f, 0f, speed* Time.deltaTime);
}
