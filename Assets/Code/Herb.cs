using UnityEngine;

public class Herb : MonoBehaviour
{


    public Vector3 offset;//藥草與滑鼠的距離差
    public bool InMortar = false;//判斷藥草是否在杵臼內 初始為否
    public int HitCount = 0;//杵臼碰撞計數器 初始為0



    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Mortar")//如果碰撞物件的標籤為杵臼
        {
            InMortar = true;//判斷藥草在杵臼內
            Debug.Log("藥草在我的裡面了，你可以開始捶他了");

        }
        if (other.tag == "Pestle" && InMortar && HitCount < 3)
        {
            HitCount++;//碰撞計數器加1
            Debug.Log("你爆捶了藥草" + HitCount + "次");
        }
        if (HitCount >= 3)
        {
            Debug.Log("你真棒藥草做好了！！");
        }




    }



    void Update()
    {

    }
}
