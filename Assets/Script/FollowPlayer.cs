using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3 (-9.2f, 5.37f, -0.29f);
   
    public GameObject thirdPersonCamera;
    private Vector3 thirdCamera = new Vector3 (0.16f, 2.05f, 0.14f);

     private bool toogleCamera = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            toogleCamera = !toogleCamera;
            
        }
        if (!toogleCamera)
        {
            transform.position = player.transform.position + thirdCamera;
        }
        else
        {
            //toogleCamera = false;
            transform.position = player.transform.position + offset;
        }
             

    }

     
    
    
}
