using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndClass : MonoBehaviour
{
    public int love = 100;
    public int age = 20;

    void Start()
    {
        //====================== if 문 사용법 ===========================
        if(love > 70)
        {
            Debug.Log("굿 엔딩");
        }
        else if(love <= 70)
        {
            Debug.Log("배드 엔딩");
        }

        //====================== 논리 연산자 ============================

        if(age > 7 && age < 18)                 //나이가 7초와 18미만을 동시(&&)에 만족할 경우
        {
            Debug.Log("의무 교육을 받고 있습니다");
        }
        if (age < 13 || age > 70)               //나이가 13미만 또는(||) 70초과일 경우
        {
            Debug.Log("일을 할수 없는 나이입니다");
        }
    }


    void Update()
    {
        
    }
}
