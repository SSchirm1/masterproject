
using UnityEngine;
using UnityEngine.InputSystem;
public class BoardSpawnScript : MonoBehaviour
{
    public GameObject leftHand;
    public GameObject RightHand;
    public GameObject cam;

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
       var camRotation = cam.GetComponent<Transform>().rotation;

        //float boardScale = Mathf.Abs(rightPos.x-leftPos.x);
        float boardScale = Vector3.Distance(leftPos, rightPos);

        Debug.Log("Board in meter" + boardScale);

       
        Debug.Log(camRotation.y*180);
        var camForward = new Vector3(cam.transform.forward.x, 0, cam.transform.forward.z);
        GameObject newBoard = Instantiate(boardPrefab, Vector3.Lerp(leftPos, rightPos, 0.5f)+ camForward*boardScale/2, Quaternion.LookRotation(camForward, Vector3.up));
       
        newBoard.GetComponent<Transform>().localScale = new Vector3(boardScale, boardScale,boardScale);
    
        }
    }
}
