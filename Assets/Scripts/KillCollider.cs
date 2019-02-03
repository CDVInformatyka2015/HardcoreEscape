using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillCollider : MonoBehaviour {

    private LifeScript life;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

    }
    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("GAME OVER");
        }
    }
}
