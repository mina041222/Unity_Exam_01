using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quaternion_Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Quaternion rotation = Quaternion.Euler(new Vector3(0, 60, 0));

        Vector3 eulerRotation = rotation.eulerAngles;

        Debug.Log(eulerRotation);

        Quaternion a = Quaternion.Euler(30, 0, 0);
        Quaternion b = Quaternion.Euler(0, 60, 0);

        Quaternion rotation_Temp = a * b;

        eulerRotation = rotation_Temp.eulerAngles;
        Debug.Log(eulerRotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
