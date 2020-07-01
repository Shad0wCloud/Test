using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorchange : MonoBehaviour
{
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cube (1)" || collision.gameObject.name == "Cube (2)")
        {
            GetComponent<MeshRenderer>().material.color = new Color(112, 217, 0);
        }
        if (collision.gameObject.name == "Cube (3)" || collision.gameObject.name == "Cube (4)")
        {
            GetComponent<MeshRenderer>().material.color = new Color(255, 255, 19);
        }
    }*/

    private void Update()
    {
        StartCoroutine(Gogo());
    }

    IEnumerator Gogo()
    {
        yield return new WaitForSeconds(2f);
        transform.Translate(Vector3.forward * 50f *Time.deltaTime);

    }
        IEnumerator GetCollor() {
        int r = Random.Range(20, 255);
        int g = Random.Range(20, 255);
        int b = Random.Range(20, 255);
        yield return new WaitForSeconds(1f);
        //GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0, 255), Random.Range(0, 255), Random.Range(0, 255));
        GetComponent<MeshRenderer>().material.color = new Color(r,g,b);
    }
}
