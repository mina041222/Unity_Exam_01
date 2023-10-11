using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform childTransform;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -1, 0);     //자신의 전역 위치를 (0, -1, 0)으로 변경

        childTransform.localPosition = new Vector3(0, 2, 0);    //자식의 지역 위치를 (0, 2, 0)으로 변경

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));       //자신의 저녁 회전을 (0, 0, 30)으로 변경

        childTransform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0)); //자식의 지역 회전을 (0, 60, 0)으로 변경

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))       //위쪽 화살표를 누르고 있으면
        {
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime);         //초당 (0,1,0)의 속도로 평행이동
        }

        if(Input.GetKey(KeyCode.DownArrow))     //아래쪽 화살표를 누르고 있으면
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);        //초당 ( 0, -1, 0)의 속도로 평행 이동
        }

        if(Input.GetKey(KeyCode.LeftArrow)) //왼쪽 방향키를 누르면 
        {
            transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime);      //초당 (0, 0, 180) 회전
            childTransform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime);     //초당(0, 180, 0) 회전
        }

        if (Input.GetKey(KeyCode.RightArrow)) //왼쪽 방향키를 누르면 
        {
            transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime);      //초당 (0, 0, -180) 회전
            childTransform.Rotate(new Vector3(0, -180, 0) * Time.deltaTime);     //초당(0, 180, 0) 회전
        }
    }
}
