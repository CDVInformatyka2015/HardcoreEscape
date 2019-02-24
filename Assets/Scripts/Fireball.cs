using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {

    public float speed = 10.0f;
    public int damage = 1;
    public float lifetime = 3.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, speed * Time.deltaTime);
        Destroy(gameObject, lifetime);
	}

    private void OnTriggerEnter(Collider other)
    {
        PlayerCharacter player = other.GetComponent<PlayerCharacter>();
        if (player!=null)
        {
            player.Hurt(damage);
        }
        Destroy(this.gameObject);
    }
}
