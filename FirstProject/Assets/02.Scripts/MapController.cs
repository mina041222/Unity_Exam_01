using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public GameObject MapTile;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)            // 0 ~ 10까지 X축값
        {
            for (int j = 0; j < 10; j++)        //0 ~ 9까지 Z축값
            {
                GameObject go = (GameObject)Instantiate(MapTile);       //받가을 생성하고 (100개의 맵타일)
                go.transform.position = new Vector3(i, 0, j) + new Vector3(0.5f, 0, 0.5f);           //각 축 값으로 생성시 이동
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
