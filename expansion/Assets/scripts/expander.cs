using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expander : MonoBehaviour
{
    public Transform currentPos;
    public GameObject spawnee;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown("a")) {
        Vector3 xIncrease = new Vector3(1, 0, 0);
        currentPos.position += xIncrease;
        Instantiate(spawnee, currentPos);
        
        }
    }
}
