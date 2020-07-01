using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coroutins : MonoBehaviour
{
    public GameObject obj;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F)) {
            StartCoroutine(test1());
        }
        if (Input.GetKey(KeyCode.O)) {
            obj.transform.position = new Vector3(obj.transform.position.x+1, obj.transform.position.y, obj.transform.position.z);
        }
    }

    IEnumerator test1() {
        int y = 5;
        for (int i = 0; i < 2400; i+=3) {
            yield return new WaitForSeconds(0);
            int x = i % 60;
            Instantiate(obj, new Vector3(x,y,-3), Quaternion.identity);
            Instantiate(obj, new Vector3(0, y, x), Quaternion.identity);
            if (i % 60 == 0)
            {
                y+=3;
            }
        }
    }
}
