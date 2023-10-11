using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;           //이동에 사용할 리지드바디 컴포넌트
    public float speed = 8.0f;                  //이동 속력

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow) == true)    //위쪽 방향키 입력이 감지된 경우 Z방향 힘주기
        //{
            //playerRigidbody.AddForce(0f, 0f, speed);    //위쪽 방향 == Z축
        //}

        //if (Input.GetKey(KeyCode.DownArrow) == true)    //아래쪽 방향키 입력이 감지된 경우 -Z방향 힘주기
        //{
            //playerRigidbody.AddForce(0f, 0f, -speed);    //아래쪽 방향 == -Z축
        //}

        //if (Input.GetKey(KeyCode.RightArrow) == true)    //오른쪽 방향키 입력이 감지된 경우 x방향 힘주기
        //{
            //playerRigidbody.AddForce(speed, 0f, 0f);    //위쪽 방향 == x축
        //}

        //if (Input.GetKey(KeyCode.LeftArrow) == true)    //위쪽 방향키 입력이 감지된 경우 -x방향 힘주기
        //{
            //playerRigidbody.AddForce(-speed, 0f, 0f);    //위쪽 방향 == -x축
        //}

        float xInput = Input.GetAxis("Horizontal"); //수평축
        float zInput = Input.GetAxis("Vertical");   //수직축

        Debug.Log("xInput : " + xInput + ", zInput :" + zInput);

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Debug.Log("xSpeed : " + xSpeed + ", zSpeed :" + zSpeed);

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed); //Vector3 속도를 (xSpeed, 0, zSpeed)로 생성
        playerRigidbody.velocity = newVelocity; //리지드바디의 속도에 newVelocity 할당
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
