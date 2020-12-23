using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 作为一个 唯一的数据模型 一般情况 要不自己是 个单例模式对象
/// 要不自己存在一个单例模式对象中
/// </summary>
public class Data
{
    #region 声明属性

    private int lv;

    public int Lv{
        get{return lv;}
    }

    private int jinbi;
    public int Jinbi{
        get{return jinbi;}
    }

    private int zhuangsi;
    public int Zhuangsi{
        get{return zhuangsi;}
    }

    private int hongBaosi;

    public int HongBaosi{
        get{return hongBaosi;}
    }

    private int langBaosi;
    public int LangBaosi{
        get{return langBaosi;}
    }


    private int gongjian;

    public int Gongjian{
        get{return gongjian;}
    }

    #endregion
    
    
    /// <summary>
    /// 通知外部 更新的事件
    /// 通过 事件和外部建立联系 而不是直接获取外部面板
    /// </summary>
    private event System.Action<Data> updateEvent;
    

    //通过单例模式，使用 data
    private static Data instance=null;
    public static Data GetInstance{

        get{
        
                if(instance==null){
                    instance=new Data();
                    instance.Init();
                }
                return instance;
        
            }
        
        
    }


    //初始化
    private void Init(){
        lv=PlayerPrefs.GetInt("lv",1);
        jinbi=PlayerPrefs.GetInt("jinbi",999);
        zhuangsi=PlayerPrefs.GetInt("zhuangsi",999);
        hongBaosi=PlayerPrefs.GetInt("hongBaosi",100);
        langBaosi=PlayerPrefs.GetInt("langBaosi",100);
        gongjian=PlayerPrefs.GetInt("gongjian",200);

    }

    //存储数据 
    private void SaveData(){
        PlayerPrefs.SetInt("lv",lv);
        PlayerPrefs.SetInt("jinbi",lv);
        PlayerPrefs.SetInt("zhuangsi",lv);
        PlayerPrefs.SetInt("hongBaosi",lv);
        PlayerPrefs.SetInt("langBaosi",lv);
        PlayerPrefs.SetInt("gongjian",lv);

        //保存数据后 执行更新方法
        UpdateInfo();
    }


    //升级
    public void LevUp(){
        lv+=1;

        jinbi+=lv;
        zhuangsi+=lv;
        hongBaosi+=lv;
        langBaosi+=lv;
        gongjian+=lv;

        //升级后需要保存数据
        SaveData();

    }

    //通知外部根据数据的方法
    public void AddEventListener(System.Action<Data> funtion){
        updateEvent+=funtion;
    }

    public void RemoveEventListener(System.Action<Data> funtion){
        updateEvent-=funtion;
    }

    /// <summary>
    /// 通知外部 更新数据方法
    /// </summary>
    private void UpdateInfo(){
        //找到对应的 使用数据的脚本 去更新数据
        if(updateEvent!=null){
            updateEvent(this);
        }
    }
}
