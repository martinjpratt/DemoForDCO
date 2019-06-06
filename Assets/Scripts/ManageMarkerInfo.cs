using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageMarkerInfo : MonoBehaviour {

    public string objectName;
    public string url;

    public void GoToURL()
    {
        Application.OpenURL(url);
    }

    public void DeleteMarker()
    {
        Destroy(GameObject.Find(objectName));
        GameObject.FindGameObjectWithTag("scrollAreaManager").GetComponent<ScrollAreaManager>().scrollerShow = false;
    }

}
