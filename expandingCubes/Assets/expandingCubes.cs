using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expandingCubes : MonoBehaviour
{
    public GameObject expandingHomie;
    public float distance;
    public Transform currentPos;
    
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        if(Input.GetKeyDown("a") && cubeScript.crashed == false){
            
            Instantiate(expandingHomie, currentPos.position + (transform.right * distance), transform.rotation);
            Instantiate(expandingHomie, currentPos.position + (transform.right * -distance), transform.rotation);
            distance += 1;
            
        }
        
    }

    
}


    