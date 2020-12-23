using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MianView : MonoBehaviour
{
    
    public Button btnUpdate;
    //public Button btnClose;

    public Text texLv;
    public Text tex金币;
    public Text tex钻石;



    // Update is called once per frame
   public void UpdateInfo(Data PlayerData)
    {
        texLv.text=PlayerData.Lv.ToString();
        tex金币.text=PlayerData.Jinbi.ToString();
        tex钻石.text=PlayerData.Zhuangsi.ToString();
    }
}
