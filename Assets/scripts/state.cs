using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 状态模式
/// 通过改变状态，改变行为
/// </summary>
public abstract class state{
    public abstract void doWork();
    
}

public class Happy :state{
    public override void doWork()
    {
        Debug.Log("积极主动！");
    }
}

public class Sad:state{
    public override void doWork()
    {
        Debug.Log("无精打采！");
    }
}
