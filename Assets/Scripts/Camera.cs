using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z+1);
        }if (Input.GetKey(KeyCode.S)) {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z-1);
        }
        if (Input.GetKey(KeyCode.D)) {
            this.transform.position = new Vector3(this.transform.position.x+1, this.transform.position.y, this.transform.position.z);
        }
        if (Input.GetKey(KeyCode.A)) {
            this.transform.position = new Vector3(this.transform.position.x-1, this.transform.position.y, this.transform.position.z);
        }if (Input.GetKey(KeyCode.Q)) {
            this.transform.localEulerAngles = new Vector3(this.transform.localEulerAngles.x, this.transform.localEulerAngles.y -1, this.transform.localEulerAngles.z);
        }
        if (Input.GetKey(KeyCode.E)) {
            this.transform.localEulerAngles = new Vector3(this.transform.localEulerAngles.x, this.transform.localEulerAngles.y+1, this.transform.localEulerAngles.z);
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y+1, this.transform.position.z);
        }
        if (Input.GetKey(KeyCode.RightControl))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y-1, this.transform.position.z);
        }
    }
}
