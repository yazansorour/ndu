using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SplashScreen : MonoBehaviour
{

    public Image[] splash;
    public string loadLevel;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        // set alpha to 0 to all
        for (int i = 0; i < splash.Length; i++)
        {
            splash[i].canvasRenderer.SetAlpha(0.0f);
        }

        // set image aplha -> 0
        for (int i = 0; i < splash.Length; i++)
        {

            fade(true, splash[i]);
            yield return new WaitForSeconds(2.0f);
            fade(false, splash[i]);
            yield return new WaitForSeconds(2.0f);
        }
        /*
        splash[0].canvasRenderer.SetAlpha(0.0f);
        splash[1].canvasRenderer.SetAlpha(0.0f);

        
        // fade the image
        fade(true, splash[0]);
        // wait  2 sec
        yield return new WaitForSeconds(2.5f);
        // fade out
        fade(false, splash[0]);
        yield return new WaitForSeconds(2.0f);

        // fade the image
        fade(true, splash[1]);
        // wait  2 sec
        yield return new WaitForSeconds(2.5f);
        // fade out
        fade(false, splash[1]);
        yield return new WaitForSeconds(2.0f);
        */

        // go to the next scene
        SceneManager.LoadScene(loadLevel);
    }

    void fade(bool alpha, Image image)
    {
        if (alpha)
        {
            image.CrossFadeAlpha(1.0f, 1.5f, false);
        }
        else
        {
            image.CrossFadeAlpha(0.0f, 2.5f, false);
        }
    }

}
