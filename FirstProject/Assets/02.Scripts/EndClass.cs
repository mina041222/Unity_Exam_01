using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndClass : MonoBehaviour
{
    public int love = 100;
    public int age = 20;

    void Start()
    {
        //====================== if �� ���� ===========================
        if(love > 70)
        {
            Debug.Log("�� ����");
        }
        else if(love <= 70)
        {
            Debug.Log("��� ����");
        }

        //====================== �� ������ ============================

        if(age > 7 && age < 18)                 //���̰� 7�ʿ� 18�̸��� ����(&&)�� ������ ���
        {
            Debug.Log("�ǹ� ������ �ް� �ֽ��ϴ�");
        }
        if (age < 13 || age > 70)               //���̰� 13�̸� �Ǵ�(||) 70�ʰ��� ���
        {
            Debug.Log("���� �Ҽ� ���� �����Դϴ�");
        }
    }


    void Update()
    {
        
    }
}
