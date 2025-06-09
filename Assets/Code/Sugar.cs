using UnityEngine;

public class Sugar : MonoBehaviour
{

    public bool InKiln = false;//判斷蔗糖是否再甕窯內 初始為否
    public float BakeTime = 3f;//火烤時間要三秒
    public float Timer = 0f;//計時器 初始為0




    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Kiln") // 碰到甕窯開始烤
        {
            InKiln = true;
            Debug.Log("燒燒燒烤蔗糖！");
            Timer = 0f; // 重置計時器
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (!InKiln) return; // 如果沒在烤，就跳過

        Timer += Time.deltaTime;

        if (Timer >= BakeTime)
        {
            Debug.Log("兄弟你的蔗糖要糙輝搭了！");
            InKiln = false; // 烤完就停下來
            Timer = 0f;     // 重設計時器

        }
    }
}
