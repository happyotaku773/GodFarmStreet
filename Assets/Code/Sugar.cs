using UnityEngine;

public class Sugar : MonoBehaviour
{

    public bool InKiln = false;//�P�_���}�O�_�A�|�`�� ��l���_
    public float BakeTime = 3f;//���N�ɶ��n�T��
    public float Timer = 0f;//�p�ɾ� ��l��0




    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Kiln") // �I���|�`�}�l�N
        {
            InKiln = true;
            Debug.Log("�N�N�N�N���}�I");
            Timer = 0f; // ���m�p�ɾ�
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (!InKiln) return; // �p�G�S�b�N�A�N���L

        Timer += Time.deltaTime;

        if (Timer >= BakeTime)
        {
            Debug.Log("�S�̧A�����}�n�W���f�F�I");
            InKiln = false; // �N���N���U��
            Timer = 0f;     // ���]�p�ɾ�

        }
    }
}
