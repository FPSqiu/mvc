using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MianController : MonoBehaviour
{

    private MianView mianView;


    private static MianController controller;

    public static MianController Controller{
        get {
            return controller;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //初始化数据
        mianView=this.GetComponent<MianView>();
        mianView.UpdateInfo(Data.GetInstance);

        mianView.btnUpdate.onClick.AddListener(()=>{
            RoleController.Show();
        });

        Data.GetInstance.AddEventListener(UpdateInfo);
    }

    private void UpdateInfo(Data data){
        mianView.UpdateInfo(data);
    }

    #region 显示隐藏 界面
    public static void Show(){

        if(controller==null){
            //实例化对象
            GameObject res=Resources.Load<GameObject>("Prefabs/MainUI");
            GameObject obj=Instantiate(res);
            //设置父对象
            obj.transform.SetParent(GameObject.Find("Canvas_MainPanel").transform,false);
            controller=obj.GetComponent<MianController>();
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
