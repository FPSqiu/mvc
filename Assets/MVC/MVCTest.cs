using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MVCTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M)){
            MianController.Show();
        }

        if(Input.GetKeyDown(KeyCode.N)){
            MianController.Hide();
        }

         if(Input.GetKeyDown(KeyCode.Q)){
            RoleController.Show();
        }

        if(Input.GetKeyDown(KeyCode.W)){
            RoleController.Hide();
        }
    }
}
