using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mytrigger : MonoBehaviour {

    //public Button yourButton;
    Animator anim;
    bool playmode = false;
    void Start()
    {
        anim = GetComponent<Animator>();
        //anim = GetComponent<Animator>();
      //  ;        //Button btn = yourButton.GetComponent<Button>();
        //btn.onClick.AddListener(TaskOnClick);
    }

    void Update()
    {
        //if (Input.GetKeyDown("space") && !playmode)
		if (Input.GetMouseButtonDown(0) && !playmode)
        {
            anim.enabled = true;
            anim.Play("myglobe");
            Debug.Log("You have clicked the button and start!");
            playmode = true;
        }
        //else if(Input.GetKeyDown("space") && playmode)
		else if (Input.GetMouseButtonDown(0) && playmode)
        {
            anim.enabled = false;
            anim.Play("idle");
            Debug.Log("You have clicked the button! and stop");
            playmode = false;
            //anim.Stop("myglobe");
            //anim.active = false;
            // anim.Stop();
        }
        //Debug.Log("You have clicked the button!");
    }
}
