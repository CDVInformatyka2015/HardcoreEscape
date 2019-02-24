using UnityEngine;
using UnityEngine.SceneManagement;

public class KillCollider : MonoBehaviour {
   
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

    }
    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player"))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("Menu");
            Debug.Log("GAME OVER");
        }
    }
}
