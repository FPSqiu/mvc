using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Person 张三=new Person ();
        //张三.DoSomething(new Happy());
        张三.DoSomething(new Sad());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
