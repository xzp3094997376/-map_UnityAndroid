using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TestAndroid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        //AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
        //string message = "this is my title";
        //string body = "this is my content";
        //jo.Call("ShareText", message, body);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2f-150, Screen.height / 2f, 300, 100), "Android call Unity"))
        {
            using (AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                using (AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity"))
                {

                    jo.Call("UnityCallAndroid");
                }
            }
        }


    }


    public Text Text;
    public void UnityMethod(string str)
    {
        Debug.Log("UnityMethod被调用，参数：" + str);
        Text.text = str;
    }
}
