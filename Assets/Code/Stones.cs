using UnityEngine;

public class Stones : MonoBehaviour
{
    public bool InKiln = false; // �P�_�d�۬O�_�b�|�`�� ��l���_
    public bool InMortar = false;// �P�_�d�۬O�_�b�S�ݤ� ��l���_
    public int MakeCount = 0; //�d�ۻs�@�p�ƾ� ��l��0
    public float BakeTime = 5f;//���N�ɶ��n�T��
    public float sTimer = 0f;//�p�ɾ� ��l��0
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Mortar")
        {
            InMortar = true;
            Debug.Log("�}�l��y��y�d��");

        }

        if (other.tag == "Pestle" && InMortar && MakeCount < 4)
        {
            MakeCount++;//�I���p�ƾ��[1
            Debug.Log("�A�V���F��d��" + MakeCount + "��");
            if (MakeCount >= 4)
            {
                Debug.Log("�H���F�N��ڪ��ߤ@��");
            }
        }

        if (other.tag == "Kiln" && MakeCount >= 4)
        {
            InKiln = true;
            BakeTime = 0f;
            Debug.Log("�H��U�N");

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!InKiln || MakeCount < 4) return;// �p�G�S�b�N�ΨS���H�A�N���L 


        sTimer += Time.deltaTime;
        if (sTimer >= BakeTime)
        {
            Debug.Log("���ߧA�A4�Ӻ}�G�����K�_�_�O");
            InKiln = false; // �N���N���U��
            sTimer = 0f;     // ���]�p�ɾ�

        }

    }
}
