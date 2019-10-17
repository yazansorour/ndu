using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Camera camera;

    public GameObject menu;
    public GameObject menuButton;

    RaycastHit hitResult;

    GameObject SelectedWall;
    GameObject LastSelectedWall;

    // Start is called before the first frame update
    void Start()
    {
        this.camera = Camera.main;
        menu.SetActive(false);
        menuButton.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        // Check if Player Looking to Object 
        if(Physics.Raycast(camera.transform.position ,
            camera.transform.TransformDirection(Vector3.forward) , out hitResult , Mathf.Infinity))
        {
            // Check if player looking to wall
            if (hitResult.transform.tag == "Wall")
            {
                    // Check if player clicked
                    SelectedWall = hitResult.transform.gameObject;


                    if (menuButton.activeSelf)
                    {
                      // Check if Last selected wall is the same current wall
                      if (LastSelectedWall.transform.GetInstanceID() == SelectedWall.transform.GetInstanceID())
                      {
                            // show The Menu
                            showMenuButton(true);

                      }
                      // if not the same wall just hide it
                      else
                      {
                            showMenuButton(false);
                            menu.SetActive(false);
                      }
                     
                    }
                    else
                    {
                        showMenuButton(true);
                    }
                

                    LastSelectedWall = SelectedWall;
               
                // Move Wall forward to player know what wall selected
            }


            if (hitResult.transform.tag == "MaterialElement")
            {
                // Check if Player Select  Wall or Floor
                // Change the Wall or floor Material
               
                    if (LastSelectedWall != null)
                    {
                        LastSelectedWall.GetComponent<Renderer>().material = hitResult.transform.GetComponent<Renderer>().material;
                        //Debug.Log(LastSelectedWall.transform.name);
                    }

            }
           
        }
    }

   private void showMenuButton (bool show)
   {
        if(show)
        {
            menuButton.SetActive(true);
            menuButton.transform.position = SelectedWall.transform.position ;
            menuButton.transform.Translate(-Vector3.right * 5); // move left
            menuButton.transform.Translate(-Vector3.up * 0.5f); // move down
            menuButton.transform.rotation = SelectedWall.transform.rotation;
        }
        else
        {
            menuButton.SetActive(false);
        }
   }

   public void showWallMenu ()
   {
        if (!menu.activeSelf)
        {
            menu.SetActive(true);
            // set the menu position
            menu.transform.position = (SelectedWall.transform.position  + SelectedWall.transform.TransformDirection(Vector3.forward * -1) )+ Vector3.up * -1;
            menu.transform.rotation = SelectedWall.transform.rotation;
        }
        else
        {
            menu.SetActive(false);
        }
   }

}
