using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    public Image menuButton;
    // Start is called before the first frame update
    void Start()
    {
        menuButton.color = new Color32(153/255,153/255,32/255,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
