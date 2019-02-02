using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ludek : MonoBehaviour {

    public Animator anim;

	// Use this for initialization
	void Start () {
        this.anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("1")){
            anim.Play("Ludek Walk", -1, 0f);
        }else if (Input.GetKeyDown("2")){
            anim.Play("Ludek atak", -1, 0f);
        }else if (Input.GetKeyDown("3")){
            anim.Play("Ludek skok", -1, 0f);
        }

    }
}
