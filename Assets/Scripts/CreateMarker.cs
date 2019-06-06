using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateMarker : MonoBehaviour {

    public InputField title;
    public InputField latitude;
    public InputField longitude;
    public InputField url;
    public GameObject marker;
    public Color pickedColor;

    // Use this for initialization
    void Start () {
		
	}

    public void UpdateColor(ColorPicker colorPicker)
    {
        pickedColor = colorPicker.CurrentColor;
    }


    public void PositionMarker()
    {
        float lat = float.Parse(latitude.text);
        float lon = float.Parse(longitude.text);
        float xpos = 1 * Mathf.Cos(lat * Mathf.Deg2Rad) * Mathf.Cos((lon - 90) * Mathf.Deg2Rad) * -1;
        float zpos = 1 * Mathf.Cos(lat * Mathf.Deg2Rad) * Mathf.Sin((lon - 90) * Mathf.Deg2Rad) * -1;
        float ypos = 1 * Mathf.Sin(lat * Mathf.Deg2Rad);
        GameObject newObject = Instantiate(marker);
        newObject.transform.parent = this.transform;
        newObject.transform.localPosition = new Vector3(xpos, ypos, zpos);
        newObject.name = title.text;
        newObject.GetComponent<MarkerInfo>().title = title.text;
        newObject.GetComponent<MarkerInfo>().lat = lat;
        newObject.GetComponent<MarkerInfo>().lon = lon;
        newObject.GetComponent<MarkerInfo>().dep = 0;
        newObject.GetComponent<MarkerInfo>().url = url.text;
        newObject.GetComponent<Renderer>().material.color = pickedColor;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
