using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 offset;//����P�ƹ����Z���t
    public bool InMortar = false;//�P�_����O�_�b�S�ݤ� ��l���_
    
    void OnMouseDown()//��ƹ��Q�I����
    {
        offset = transform.position - GetMouseWorldPos();//�p�⪫���m�P�ƹ�������m���Z���t
        Debug.Log("�A�����ƤF");
    }
    private void OnMouseDrag()//�ƹ��즲��
    {
        if (!InMortar)//�p�G���󤣦A�S�ݤ�
        {
            transform.position = GetMouseWorldPos() + offset;//��s�����m���ƹ���m�[�W�Z���t

        }

    }
    Vector3 GetMouseWorldPos()
    {
        Vector3 MousePos = Input.mousePosition;//���X�ƹ��b�ù�����m�K�K
        MousePos.z = Camera.main.WorldToScreenPoint(transform.position).z;//�N�ƹ���Z�b�]������Z�b
        return Camera.main.ScreenToWorldPoint(MousePos);//�N�ƹ���m�ഫ���u��@�ɮy�� �ڬݤ���QAQ
    }


    void Update()
    {

    }
}
