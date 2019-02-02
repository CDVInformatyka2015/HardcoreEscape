using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentCollision : MonoBehaviour {

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
            c.GetComponent<Kill>().Killed();
            Debug.Log("GAME OVER");
        }
    }
}
