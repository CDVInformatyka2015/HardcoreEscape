using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class AgentX : MonoBehaviour {

    private NavMeshAgent agent;
    public Transform target;

	// Use this for initialization
	void Start () {
        agent = transform.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (agent.isActiveAndEnabled && !agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
            if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                agent.SetDestination(target.position);
        //agent.Warp(target.position);
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
