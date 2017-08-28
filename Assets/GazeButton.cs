using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GazeButton : MonoBehaviour {
    public Image Imagebutton;
	// Use this for initialization
    public void greencolor()
    {
        Imagebutton.color = Color.green;
    }

    public void redcolor()
    {
        Imagebutton.color = Color.red;
    }
}
