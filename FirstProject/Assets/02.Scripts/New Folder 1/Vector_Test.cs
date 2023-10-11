using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector_Test : MonoBehaviour
{
    public Vector3 currentPos = new Vector3(1, 0, 1);   //현재 위치
    public Vector3 destPost = new Vector3(5, 3, 5);     //목적지

    // Start is called before the first frame update
    void Start()
    {
        Vector3 dleta = destPost - currentPos;          //방향 백터

        float distance = dleta.magnitude;               //magnitude 백터의 크기 => 거리

        Debug.Log(distance);

        float distanceLib = Vector3.Distance(currentPos, destPost);     //유니티에서 지원하는 함수로 거리 구하기

        Debug.Log(distanceLib);

        Vector3 dircation = (destPost - currentPos).normalized;         //currentPost에서 destPos으로 향하는 방향 백터

        Vector3 newPos = currentPos + dircation * 10;                   //목적지를 향해 10만큼 이동한 새로운 위치

        Debug.Log(newPos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
