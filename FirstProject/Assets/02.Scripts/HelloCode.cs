using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    public int Gold = 1000;                 //public은 인스팩터 창에서 확인을 지원해줌 
   
    void Start()
    {
        Debug.Log("GOLD : " + Gold.ToString());

        //케릭터 프로필을 변수로 만든다
        string characterName = "라라";          //문자열 characterName 선언하고 값 입력
        char bloodType = 'A';                   //문자 BloodType 선언& 값 입력
        int age = 17;                           //실수 나이값 선언
        float height = 168.3f;                  //높이값 선언 
        bool isFemale = true;                   // bool값 선언

        //생성한 변수를 콘솔에 출력
        Debug.Log("케릭터 이름 : " + characterName);
        Debug.Log("혈액형 : " + bloodType);
        Debug.Log("나이 : " + age);
        Debug.Log("키 : " + height);
        Debug.Log("여성 : " + isFemale);
    }

}
