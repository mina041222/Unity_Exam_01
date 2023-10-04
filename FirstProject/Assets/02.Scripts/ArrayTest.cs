using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    public int[] admin = new int[100];

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < admin.Length; i++)
        {
            admin[i] = UnityEngine.Random.Range(0, 100);
        }

        for (int i = 0; i < admin.Length; i++)
        {
            Debug.Log(admin[i]);
        }
    }
}
