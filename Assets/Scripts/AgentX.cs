using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AgentX : MonoBehaviour {

    private NavMeshAgent agent;
    public Transform target;
    public Component TextLife;
    public Component SceneSwapper;

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
            Debug.Log("Exec AgentCollinder");
            // TODO
            // Trzeba poprawić, bo nie działa na drugim respawnie.
            this.TextLife.GetComponent<LifeScript>().DecrementLife("test");
            this.SceneSwapper.GetComponent<SceneSwap>().LoadScene("SuperLabirynth");
        }
    }
}
