using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition; //Get current screen position from input for mouse
        
        //Camera position on how far to push mouse into 3d
        //if causes a NullReferenceException, select main camera
        //in the hierarchy and set its tag to MainCamera in the inspector.

        mousePos2D.z = -Camera.main.transform.position.x;
        
        //Covert the pt from 2d to 3d world space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        
        //move the x position of this Basket to the x position of the mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;

    }
}
