using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeScript : MonoBehaviour {

    public MyLifes lifes;
    private Component LifeText;

    // Use this for initialization
    void Start () {
        this.GetComponent<Text>().text = "Pozostałe życia: " + this.lifes.GetLifes();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DecrementLife(string test)
    {
        bool remLife = lifes.RemoveLife();
        if (remLife)
        {
            this.GetComponent<Text>().text = "Pozostałe życia: " + this.lifes.GetLifes();
        }
    }
}
