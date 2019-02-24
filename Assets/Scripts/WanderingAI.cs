using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WanderingAI : MonoBehaviour {

    private readonly float speed = 15.5f;
    public float obstacleRange = 5.0f;
    public bool _alive;
    [SerializeField] private GameObject fireballPrefab;
    private GameObject _fireball;
    private NavMeshAgent _agent;
    private Transform _player;

    // Use this for initialization
    void Start () {
        _alive = true;
        _agent = GetComponent<NavMeshAgent>();
        _agent.speed = speed;
        _player = GameObject.FindWithTag("Player").transform;
    }
	
	// Update is called once per frame
	void Update () {
        if (_alive)
        {
            //transform.Translate(0, 0, speed * Time.deltaTime);
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.SphereCast(ray, 0.75f, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                if (hitObject.GetComponent<PlayerCharacter>())
                {
                    if (_fireball == null)
                    {
                        _fireball = Instantiate(fireballPrefab) as GameObject;
                        _fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f) + new Vector3(0, 1f, 0f);
                        _fireball.transform.rotation = transform.rotation;
                    }
                }
                else if (hit.distance < obstacleRange)
                {
                    float angle = Random.Range(-110, 110);
                    transform.Rotate(0, angle, 0);
                }
                _agent.SetDestination(_player.position);
            }
        }
	}

    public void setAlive(bool alive)
    {
        _alive = alive;
    }

    public bool getAlive()
    {
        return _alive;
    }
}
