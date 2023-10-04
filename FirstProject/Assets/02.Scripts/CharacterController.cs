using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // 매 프레임마다 호출
    void Update()
    {
        //Vector3는 x,y,z 값을 가진 class 변수
        //Time.deltaTime 프레임 간격 시간 => 프레임 간격 시간을 더하면 일정한 시간 견격을 표현한다.
        this.gameObject.transform.position += new Vector3(0.0f, 0.0f, 1.0f) * Time.deltaTime;
    }
}
