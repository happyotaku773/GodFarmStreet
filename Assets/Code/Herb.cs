using UnityEngine;

public class Herb : MonoBehaviour
{


    public Vector3 offset;//�į�P�ƹ����Z���t
    public bool InMortar = false;//�P�_�į�O�_�b�S�ݤ� ��l���_
    public int HitCount = 0;//�S�ݸI���p�ƾ� ��l��0



    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Mortar")//�p�G�I�����󪺼��Ҭ��S��
        {
            InMortar = true;//�P�_�į�b�S�ݤ�
            Debug.Log("�į�b�ڪ��̭��F�A�A�i�H�}�l���L�F");

        }
        if (other.tag == "Pestle" && InMortar && HitCount < 3)
        {
            HitCount++;//�I���p�ƾ��[1
            Debug.Log("�A�z���F�į�" + HitCount + "��");
        }
        if (HitCount >= 3)
        {
            Debug.Log("�A�u���į󰵦n�F�I�I");
        }




    }



    void Update()
    {

    }
}
