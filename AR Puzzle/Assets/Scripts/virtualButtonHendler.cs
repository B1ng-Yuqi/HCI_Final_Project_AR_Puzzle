using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class virtualButtonHendler : MonoBehaviour
{
    public GameObject cube;
    VirtualButtonBehaviour[] vbs;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("vbs start");
        vbs = this.GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i = 0; i < vbs.Length; i++)
        {
            if (vbs[i].VirtualButtonName == "VirtualButtonUp")
            {
                Debug.Log("register 1");
                vbs[i].RegisterOnButtonPressed(objUp);
                

            }
            if (vbs[i].VirtualButtonName == "VirtualButtonDown")
            {
                Debug.Log("register 2");
                vbs[i].RegisterOnButtonPressed(objDown);
                
            }


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void objUp(VirtualButtonBehaviour obj)
    {
        Debug.Log("upup");
        
        cube.transform.Translate(0,1,0,Space.World);
        
    }
    private void objDown(VirtualButtonBehaviour obj)
        
    {
        Debug.Log("down");
        
        cube.transform.Translate(0,-1,0,Space.World);
        
    }
        

    

}
