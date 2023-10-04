using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //첫번째 실행 될때 Tag 내용을 출력한다
        Debug.Log(this.gameObject.tag);
    }

    // Update is called once per frame
    void Update()
    {
        //매 프레임마다 해당 오브젝트 이름과 Y 값을 디버그 로그에 출력한다.
        Debug.Log(this.gameObject.name = " -> Y" + this.gameObject.transform.position.y);
    }
}
