using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AgentX : MonoBehaviour {

    private NavMeshAgent agent;
    public Transform target;

	// Use this for initialization
	void Start () {
        agent = transform.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        agent.SetDestination(target.position);
	}
}
