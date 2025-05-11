using UnityEngine;

public class Herb : MonoBehaviour
{


    public Vector3 offset;//�į�P�ƹ����Z���t
    public bool InMortar = false;//�P�_�į�O�_�b�S�ݤ� ��l���_
    void OnMouseDown()//��ƹ��Q�I����
    {
        offset = transform.position - GetMouseWorldPos();//�p���į��m�P�ƹ�������m���Z���t
        Debug.Log("�A�����ƤF");
    }
    private void OnMouseDrag()//�ƹ��즲��
    {
        if (!InMortar)//�p�G�į󤣦A�S�ݤ�
        {
            transform.position = GetMouseWorldPos() + offset;//��s�į��m���ƹ���m�[�W�Z���t

        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Mortar")//�p�G�I�����󪺼��Ҭ��S��
        {
            InMortar = true;//�P�_�į�b�S�ݤ�
            Debug.Log("�į�b�ڪ��̭��F������");
        }
    }

    Vector3 GetMouseWorldPos()
    {
        Vector3 MousePos = Input.mousePosition;//���X�ƹ��b�ù�����m�K�K
        MousePos.z = Camera.main.WorldToScreenPoint(transform.position).z;//�N�ƹ���Z�b�]���į�Z�b
        return Camera.main.ScreenToWorldPoint(MousePos);//�N�ƹ���m�ഫ���u��@�ɮy�� �ڬݤ���QAQ
    }
    void Update()
    {

    }
}
