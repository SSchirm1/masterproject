using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class BoardSpawnScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject leftHand;
    public GameObject RightHand;

    public GameObject boardPrefab;

    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
       
    }

    public void spawnBoard(InputAction.CallbackContext context) {
        if(context.started){
            
        var leftPos = leftHand.GetComponent<Transform>().position;
        var rightPos = RightHand.GetComponent<Transform>().position;

        //float boardScale = Mathf.Abs(rightPos.x-leftPos.x);
        float boardScale = Vector3.Distance(leftPos, rightPos);

        Debug.Log("Board in meter" + boardScale);

        GameObject newBoard = Instantiate(boardPrefab );

        newBoard.GetComponent<Transform>().localScale = new Vector3(boardScale, boardScale,boardScale);
        newBoard.GetComponent<Transform>().position = new Vector3(leftPos.x+boardScale/2, leftPos.y, leftPos.z+boardScale/2);

        //newBoard.GetComponent<Transform>().position = new Vector3(3,3,3);
        }
    }
}
