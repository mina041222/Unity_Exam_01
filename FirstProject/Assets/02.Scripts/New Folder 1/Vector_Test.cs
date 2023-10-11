using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector_Test : MonoBehaviour
{
    public Vector3 currentPos = new Vector3(1, 0, 1);   //���� ��ġ
    public Vector3 destPost = new Vector3(5, 3, 5);     //������

    // Start is called before the first frame update
    void Start()
    {
        Vector3 dleta = destPost - currentPos;          //���� ����

        float distance = dleta.magnitude;               //magnitude ������ ũ�� => �Ÿ�

        Debug.Log(distance);

        float distanceLib = Vector3.Distance(currentPos, destPost);     //����Ƽ���� �����ϴ� �Լ��� �Ÿ� ���ϱ�

        Debug.Log(distanceLib);

        Vector3 dircation = (destPost - currentPos).normalized;         //currentPost���� destPos���� ���ϴ� ���� ����

        Vector3 newPos = currentPos + dircation * 10;                   //�������� ���� 10��ŭ �̵��� ���ο� ��ġ

        Debug.Log(newPos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
