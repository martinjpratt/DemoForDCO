using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialSwitcher : MonoBehaviour {

    public Material satelliteMaterial;
    public Material transparentMaterial;
    public Material elevationMaterial;


    public void switchMaterial(Dropdown dropdown)
    {
        if (dropdown.value == 0)
        {
            this.GetComponent<Renderer>().material = satelliteMaterial;
        }

        if (dropdown.value == 1)
        {
            this.GetComponent<Renderer>().material = transparentMaterial;
        }
        
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
