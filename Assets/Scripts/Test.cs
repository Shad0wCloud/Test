using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject[] objs;
    public GameObject cursor;
    public GameObject obj;
    private GameObject main_obj;
    int index = 0;
    public float speed = 8f;
    //Instantiate(objs[1], new Vector3(x, 10, y), Quaternion.identity);

    private void Start()
    {
        //main_obj = Instantiate(obj, new Vector3(0,3,0), Quaternion.identity);
    }

    void Update()
    {
        float zPos = Input.GetAxis("Vertical");
        float xPos = Input.GetAxis("Horizontal");
        cursor.transform.Translate(Vector3.forward * speed * zPos * Time.deltaTime);
        cursor.transform.Translate(Vector3.right * speed * xPos * Time.deltaTime);
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
