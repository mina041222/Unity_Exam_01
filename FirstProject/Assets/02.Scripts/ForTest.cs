using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++) //i++�� i += 2��� �ϸ� ¦���� ������ �ȴ�
        {
            Debug.Log(i + " ��° ���� �Դϴ�. ");
        }

        int j = 0;
        
        while(j < 10)
        {
            Debug.Log(j + " ��° ���� �Դϴ�. ");
            j++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
