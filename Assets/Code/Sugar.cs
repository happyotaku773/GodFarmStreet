using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sugar : MonoBehaviour
{
   
    public bool InKiln = false;//�P�_���}�O�_�A�|�`�� ��l���_
    public float BakeTime = 3f;//���N�ɶ��n�T��
    public float Timer = 0f;//�p�ɾ� ��l��0




    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Kiln")//�p�G�I�����󪺼��Ҭ��|�`
        {
            InKiln = true;//�P�_���}�b�|�`��
            Debug.Log("�N�N�N�N�A�ǥ��");

        }
       




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
