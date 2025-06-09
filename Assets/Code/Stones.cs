using UnityEngine;

public class Stones : MonoBehaviour
{
    public bool InKiln = false; // 判斷泥石是否在甕窯內 初始為否
    public bool InMortar = false;// 判斷泥石是否在杵臼內 初始為否
    public int MakeCount = 0; //泥石製作計數器 初始為0
    public float BakeTime = 5f;//火烤時間要三秒
    public float sTimer = 0f;//計時器 初始為0
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Mortar")
        {
            InMortar = true;
            Debug.Log("開始鍛造鍛造泥石");

        }

        if (other.tag == "Pestle" && InMortar && MakeCount < 4)
        {
            MakeCount++;//碰撞計數器加1
            Debug.Log("你敲打了爛泥石" + MakeCount + "次");
            if (MakeCount >= 4)
            {
                Debug.Log("碎掉了就跟我的心一樣");
            }
        }

        if (other.tag == "Kiln" && MakeCount >= 4)
        {
            InKiln = true;
            BakeTime = 0f;
            Debug.Log("碎渣燃燒");

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!InKiln || MakeCount < 4) return;// 如果沒在烤或沒打碎，就跳過 


        sTimer += Time.deltaTime;
        if (sTimer >= BakeTime)
        {
            Debug.Log("恭喜你，4個漂亮的鋼鐵寶寶呢");
            InKiln = false; // 烤完就停下來
            sTimer = 0f;     // 重設計時器

        }

    }
}
