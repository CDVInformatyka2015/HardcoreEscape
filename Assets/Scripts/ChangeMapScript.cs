using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMapScript : MonoBehaviour {

    public string mapName = "Menu";
    public Component _player;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collision)
    {
        if (collision.name == _player.name)
        {
            SceneManager.LoadScene(mapName);
        }
    }
}
