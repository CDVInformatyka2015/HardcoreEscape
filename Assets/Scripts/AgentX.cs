using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class AgentX : MonoBehaviour
{
    private NavMeshAgent _agent;
    public Transform target;

    // Use this for initialization
    private void Start()
    {
        _agent = transform.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (!_agent.isActiveAndEnabled || _agent.pathPending ||
            !(_agent.remainingDistance <= _agent.stoppingDistance)) return;
        
        if (!_agent.hasPath || _agent.velocity.sqrMagnitude == 0f)
            _agent.SetDestination(target.position);
        _agent.SetDestination(target.position);
    }

    private void OnTriggerEnter(Collider c)
    {
        if (!c.CompareTag("Player")) return;
        try
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("SuperLabirynth");
        }
        catch (MissingReferenceException e)
        {
            Debug.LogError(e);
            throw;
        }
    }
}