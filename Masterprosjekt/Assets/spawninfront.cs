using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawninfront : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject go;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e")) {
            Instantiate(go, transform.position + this.transform.forward/2, Quaternion.LookRotation(new Vector3(this.transform.forward.x, 0, this.transform.forward.z), Vector3.up));
        }
    }
}
