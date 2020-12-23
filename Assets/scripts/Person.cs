using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public state State;
    public void DoSomething(state state_){
        state_.doWork();
    }
}
