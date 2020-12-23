using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoleView : MonoBehaviour
{

    public Button BtnClose;
    public Button BtnUp;
    public Text texHongBaosi;
    public Text texLangBaosi;
    public Text texGongjian;


    // Update is called once per frame
    public void UpdateInfo(Data playerData)
    {
        texHongBaosi.text=playerData.HongBaosi.ToString();
        texLangBaosi.text=playerData.LangBaosi.ToString();
        texGongjian.text=playerData.Gongjian.ToString();
    }
}
