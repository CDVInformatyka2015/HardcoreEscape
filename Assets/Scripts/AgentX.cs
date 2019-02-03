using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class AgentX : MonoBehaviour
{
    private NavMeshAgent _agent;
    public Transform target;
    private GameObject _textLife;
    [FormerlySerializedAs("SceneSwapper")] public Component sceneSwapper;

    // Use this for initialization
    private void Start()
    {
        _textLife = GameObject.Find("Lifes");
        _agent = transform.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (!_agent.isActiveAndEnabled || _agent.pathPending ||
            !(_agent.remainingDistance <= _agent.stoppingDistance)) return;
        
        if (!_agent.hasPath || _agent.velocity.sqrMagnitude == 0f)
            _agent.SetDestination(target.position);
        //agent.Warp(target.position);
    }

    private void OnTriggerEnter(Collider c)
    {
        if (!c.CompareTag("Player")) return;
        
        Debug.Log("Exec AgentCollinder");
        try
        {
            _textLife.GetComponent<LifeScript>().DecrementLife("test");
        }
        catch (MissingReferenceException e)
        {
            Console.WriteLine(e);
            throw;
        }
        sceneSwapper.GetComponent<SceneSwap>().LoadScene("SuperLabirynth");
    }
}