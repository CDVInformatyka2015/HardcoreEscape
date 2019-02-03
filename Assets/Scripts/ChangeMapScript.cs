using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMapScript : MonoBehaviour {

    public string mapName = "Menu";

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        Debug.LogWarning("Jest w kolizji");
        SceneManager.LoadScene(this.mapName);
    }
}
