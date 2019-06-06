using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ExternalLink : MonoBehaviour
{
    private void OnMouseEnter()
    {
        GameObject.FindGameObjectWithTag("tooltip").GetComponent<Text>().text = "Right-click to view details";
    }
    private void OnMouseExit()
    {
        GameObject.FindGameObjectWithTag("tooltip").GetComponent<Text>().text = "";
    }


    void LateUpdate()
    {
        if (Input.GetMouseButton(1) && !EventSystem.current.IsPointerOverGameObject())
        {
            GameObject scrollAreaManager = GameObject.FindGameObjectWithTag("scrollAreaManager");
            scrollAreaManager.GetComponent<ScrollAreaManager>().scrollerShow = true;

            GameObject infoPanel = GameObject.FindGameObjectWithTag("InfoPanel");

            string labelText = string.Format("{0}\nLatitude: {1}\nLongitude: {2}", this.GetComponent<MarkerInfo>().title, this.GetComponent<MarkerInfo>().lat.ToString(), this.GetComponent<MarkerInfo>().lon.ToString());
            infoPanel.GetComponentInChildren<Text>().text = labelText;
            infoPanel.GetComponentInChildren<ManageMarkerInfo>().objectName = this.GetComponent<MarkerInfo>().title;
            infoPanel.GetComponentInChildren<ManageMarkerInfo>().url = this.GetComponent<MarkerInfo>().url;
        }
    }
}
