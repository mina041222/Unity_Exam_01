using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject spawner;              //������ ������ ������Ʈ
    public GameObject player;               //�÷��̾� ������Ʈ

    public List<GameObject> spawnerList = new List<GameObject>();       //������ ������Ʈ

    public float TotalTime = 0.0f;          //��ü üũ�ð�
    public float TimeCursur = 10.0f;        //���� �ð� ����(����)
    public float TimeCursorCheck = 0.0f;    //���� �ð� üũ flaot

    public int cursor = 0;                  //���� ���� Ŀ��
    public Transform[] spawnPos;            //���� �� �߰� ��ġ 

    void Start()
    {
        GameObject temp = (GameObject)Instantiate(spawner);                 //�����ʸ� ���� 
        spawnerList.Add(temp);
        temp.transform.position = spawnPos[cursor].transform.position;      //�޾ƿ� ��ġ�� �̵�
        cursor += 1;
    }

    // Update is called once per frame
    void Update()
    {
        TotalTime += Time.deltaTime;        //�ð� �帣�� ����
        TimeCursorCheck += Time.deltaTime;

        if(TimeCursorCheck >= TimeCursur)
        {
            TimeCursorCheck = 0.0f;

            if(spawnPos.Length > cursor)
            {
                GameObject temp = (GameObject)Instantiate(spawner);         //�����ʸ� ����
                spawnerList.Add(temp);                                      //����Ʈ�� ������ �Է�
                temp.transform.position = spawnPos[cursor].transform.position;      //�޾ƿ� ��ġ�� �̵�
                cursor += 1;                    //�ܰ� �ö� Ȯ��
            }
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(player.activeSelf == false)      //��Ƽ�갡 �Ǿ� ���� ������
            {
                for(int i = 0; i < spawnerList.Count; i++)  //������ ����Ʈ�� �����ͼ�
                {
                    Destroy(spawnerList[i]);            //�ϳ��� �ı� 
                }
                spawnerList.Clear();

                TotalTime = 0.0f;       //��ü üũ �ð�
                TimeCursur = 10.0f;     //���� �ð� ����(����)
                TimeCursorCheck = 0.0f; //���� �ð� üũ float
                cursor = 0;             //���� ���� Ŀ��

                player.SetActive(true);

                GameObject temp = (GameObject)Instantiate(spawner);                 //�����ʸ� ���� 
                spawnerList.Add(temp);
                temp.transform.position = spawnPos[cursor].transform.position;      //�޾ƿ� ��ġ�� �̵�
                cursor += 1;

            }
        }
    }
}
