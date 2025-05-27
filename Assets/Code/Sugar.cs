using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sugar : MonoBehaviour
{
   
    public bool InKiln = false;//判斷蔗糖是否再甕窯內 初始為否
    public float BakeTime = 3f;//火烤時間要三秒
    public float Timer = 0f;//計時器 初始為0




    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Kiln")//如果碰撞物件的標籤為甕窯
        {
            InKiln = true;//判斷蔗糖在甕窯內
            Debug.Log("燒燒燒燒，灰休厝");

        }
       




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
