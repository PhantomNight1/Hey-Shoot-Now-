using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M1_Player_Movement : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(0, 0, 50, Space.Self);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(0, 0, -50, Space.Self);
        }
    }
}
