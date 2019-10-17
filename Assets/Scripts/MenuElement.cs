using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialMenuElement : MonoBehaviour
{
    public GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void changeWallMaterial ()
    {
        if (wall != null)
        {  
             showWall();
             // Set Wall Material 
             wall.GetComponent<Renderer>().material = this.transform.GetChild(0).GetComponent<Renderer>().material;           
        }

    }

    public void hideWall()
    {
        wall.GetComponent<Renderer>().enabled = false;
    }

    private void showWall()
    {
        wall.GetComponent<Renderer>().enabled = true;
    }
}
