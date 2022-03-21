using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.position += Vector3.forward * Time.deltaTime;
        } else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.back;
        }else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left;
        }else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
        }
    }
}
