using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ù��° ���� �ɶ� Tag ������ ����Ѵ�
        Debug.Log(this.gameObject.tag);
    }

    // Update is called once per frame
    void Update()
    {
        //�� �����Ӹ��� �ش� ������Ʈ �̸��� Y ���� ����� �α׿� ����Ѵ�.
        Debug.Log(this.gameObject.name = " -> Y" + this.gameObject.transform.position.y);
    }
}
