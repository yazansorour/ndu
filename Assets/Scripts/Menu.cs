using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // Collection of options
    public GameObject[] groups;

    // current group option
    private int current;
    // next group option
    private int next;
    // previous group option
    private int previous;

    // Start is called before the first frame update
    void Start()
    {
        previous = 0;
        current = 0;
        next = 0;

        if (groups.Length > 1)
            next = 1;

    }

    
    public void nextGroupOptions ()
    {
        // if  next not bigger than 
       if (next  < groups.Length)
       {
            // hide current collection
            groups[current].SetActive(false);
            groups[next].SetActive(true);

            previous = current;
            current = next;
            next = current + 1;

       }
    }

    public void previousGroupOptions()
    {

        // if  next not bigger than 
        if (previous >= 0)
        {
            // hide current collection
            groups[current].SetActive(false);
            groups[previous].SetActive(true);

            next = current;
            current = previous;
            previous = current - 1;

        }

    }

}
