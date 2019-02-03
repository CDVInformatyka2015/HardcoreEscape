using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IsAgentTriggered : MonoBehaviour {

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {

    }
    void OnTriggerEnter(Collider agent)
    {
        if (agent.CompareTag("Agent"))
        {
            agent.gameObject.GetComponent<NavMeshAgent>().enabled = false;
        }
    }
    void OnTriggerExit(Collider agent)
    {
        if (agent.CompareTag("Agent"))
        {
            agent.gameObject.GetComponent<NavMeshAgent>().enabled = true;
        }
    }
}
