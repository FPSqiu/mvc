using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleController : MonoBehaviour
{

    private RoleView roleView;

    private static RoleController controller;

    public static RoleController Controller{
        get{
            return controller;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        roleView=this.GetComponent<RoleView>();
        roleView.UpdateInfo(Data.GetInstance);

        Data.GetInstance.AddEventListener(UpdateInfo);

        roleView.BtnClose.onClick.AddListener(()=>{
            Hide();
        });

        roleView.BtnUp.onClick.AddListener(()=>{

            Data.GetInstance.LevUp();
        });
    }


    private void UpdateInfo(Data data){
        roleView.UpdateInfo(data);
    }

     #region 显示隐藏 界面
    public static void Show(){

        if(controller==null){
            //实例化对象
            GameObject res=Resources.Load<GameObject>("Prefabs/道具");
            GameObject obj=Instantiate(res);
            //设置父对象
            obj.transform.SetParent(GameObject.Find("Canvas_MainPanel").transform,false);
            controller=obj.GetComponent<RoleController>();
        }
        controller.gameObject.SetActive(true);
    }

    public static void Hide(){
        if(controller!=null){
            controller.gameObject.SetActive(false);
        }
    }
    #endregion
}
