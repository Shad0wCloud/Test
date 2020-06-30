using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject[] objs;
    public GameObject cursor;
    int index = 0;
    float speed = 0.5f;
    //Instantiate(objs[1], new Vector3(x, 10, y), Quaternion.identity);

    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            cursor.transform.position = new Vector3(cursor.transform.position.x, cursor.transform.position.y, cursor.transform.position.z+speed);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            cursor.transform.position = new Vector3(cursor.transform.position.x, cursor.transform.position.y, cursor.transform.position.z-speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            cursor.transform.position = new Vector3(cursor.transform.position.x-speed, cursor.transform.position.y, cursor.transform.position.z);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            cursor.transform.position = new Vector3(cursor.transform.position.x+speed, cursor.transform.position.y, cursor.transform.position.z);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(objs[index], new Vector3(cursor.transform.position.x, cursor.transform.position.y-10, cursor.transform.position.z), Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            index = 0;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            index = 1;
        }
    }
}
