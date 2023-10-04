using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTest : MonoBehaviour
{
    void Start()
    {
        float distance = GetDistance(2, 2, 5, 6);                   //�Լ��� ���ϰ��� distance ������ �Է�
        Debug.Log("(2,2)���� (5,6)������ �Ÿ� : " + distance);      //����� �α׷� Ȯ���Ѵ�
    }

    float GetDistance(float x1, float y1 , float x2, float y2)      // ���� ���� �Ÿ��� ���ϴ� �Լ�
    {
        float width = x2 - x1;                                      // ���� �Ÿ� ���ϱ�
        float height = y2 - y1;                                     // ���� �Ÿ� ���ϱ�

        float distance = width * width + height * height;           //������ �������� ���� ��
        distance = Mathf.Sqrt(distance);                            // sqrt�� ��Ʈ�� ���� ��

        return distance;                                            //�Լ��� float�� Return�� �޾ƾ���
    }

}
