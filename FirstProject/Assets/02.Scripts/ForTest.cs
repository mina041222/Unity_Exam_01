using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++) //i++을 i += 2라고 하면 짝수만 나오게 된다
        {
            Debug.Log(i + " 번째 순번 입니다. ");
        }

        int j = 0;
        
        while(j < 10)
        {
            Debug.Log(j + " 번째 순번 입니다. ");
            j++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
