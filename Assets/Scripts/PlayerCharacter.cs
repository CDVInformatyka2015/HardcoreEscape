using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

    public int _health;
	// Use this for initialization
	void Start () {
        _health = 5;
	}

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void Hurt (int damage) {
        _health -= damage;
	}
}
