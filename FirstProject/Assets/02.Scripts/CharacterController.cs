using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // �� �����Ӹ��� ȣ��
    void Update()
    {
        //Vector3�� x,y,z ���� ���� class ����
        //Time.deltaTime ������ ���� �ð� => ������ ���� �ð��� ���ϸ� ������ �ð� �߰��� ǥ���Ѵ�.
        this.gameObject.transform.position += new Vector3(0.0f, 0.0f, 1.0f) * Time.deltaTime;
    }
}
