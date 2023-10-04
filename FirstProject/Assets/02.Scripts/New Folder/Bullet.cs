using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8.0f;      //ź�� �̵��ӷ�
    private Rigidbody bulletRigidbody;      //�̵��� ����� ������ٵ�

    private void OnTriggerEnter(Collider other)         //Ʈ���� �⵿�� �ڵ����� ����Ǵ� �޼���
    {
        if(other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();     //���� ���� ������Ʈ���� PlayerController ������Ʈ ��������

            if(playerController != null)                        //�������κ��� PlayerController ������Ʈ�� �������� �����ߴٸ�
            {
                playerController.Die();                         //���� PlayerController ������Ʈ�� Die()�޼��� ����
            }
        }
    }
    void Start()
    {
        //���� ������Ʈ���� RigidBody ������Ʈ�� ã�Ƽ� BulletRigidbady �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();
        //������ �ٵ� �ӵ� = ���ʹ��� * �̵��ӷ�
        bulletRigidbody.velocity = transform.forward * speed;

        //3�ʵڿ� �ڽ��� ���� ������Ʈ �ı�
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
