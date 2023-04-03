using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    float speed = 20f;
    public GameObject center_object;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.eulerAngles.y < 89f || transform.eulerAngles.y > 270f) 
            {
                transform.RotateAround(center_object.transform.position, Vector3.up, speed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.eulerAngles.y < 90f || transform.eulerAngles.y > 271f) 
            {
                transform.RotateAround(center_object.transform.position, Vector3.down, speed * Time.deltaTime);
            }
        }
    }
}
