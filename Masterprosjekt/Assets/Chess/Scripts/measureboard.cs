using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class measureboard : MonoBehaviour

{

    public GameObject board;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(board.GetComponent<Collider>().bounds.size);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
