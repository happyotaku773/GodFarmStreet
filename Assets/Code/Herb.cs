using UnityEngine;

public class Herb : MonoBehaviour
{


    public Vector3 offset;//藥草與滑鼠的距離差
    public bool InMortar = false;//判斷藥草是否在杵臼內 初始為否
    void OnMouseDown()//當滑鼠被點擊時
    {
        offset = transform.position - GetMouseWorldPos();//計算藥草位置與滑鼠場景位置的距離差
        Debug.Log("你抓到材料了");
    }
    private void OnMouseDrag()//滑鼠拖曳時
    {
        if (!InMortar)//如果藥草不再杵臼內
        {
            transform.position = GetMouseWorldPos() + offset;//更新藥草位置為滑鼠位置加上距離差

        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Mortar")//如果碰撞物件的標籤為杵臼
        {
            InMortar = true;//判斷藥草在杵臼內
            Debug.Log("藥草在我的裡面了ㄚㄚㄚ");
        }
    }

    Vector3 GetMouseWorldPos()
    {
        Vector3 MousePos = Input.mousePosition;//揪出滑鼠在螢幕的位置嘿嘿
        MousePos.z = Camera.main.WorldToScreenPoint(transform.position).z;//將滑鼠的Z軸設為藥草的Z軸
        return Camera.main.ScreenToWorldPoint(MousePos);//將滑鼠位置轉換為真實世界座標 我看不懂QAQ
    }
    void Update()
    {

    }
}
