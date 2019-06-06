using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollAreaManager : MonoBehaviour {

    public bool scrollerShow;
    bool checkBool;
    public GameObject scroller;
    

    // Use this for initialization
    void Start () {
        checkBool = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (scrollerShow && !checkBool)
        {
            scroller.GetComponent<CanvasGroup>().alpha = 1;
            checkBool = true;
        }
        if (!scrollerShow && checkBool)
        {
            scroller.GetComponent<CanvasGroup>().alpha = 0;
            checkBool = false;
        }
	}
}
