using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifeScript : MonoBehaviour {

    public MyLifes lifes;
    private Component _lifeText;

    // Use this for initialization
    private void Start ()
    {
        GetComponent<Text>().text = "Pozostałe życia: " + lifes.GetLifes();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DecrementLife(string test)
    {
        bool remLife = lifes.RemoveLife();
        if (remLife)
        {
            GetComponent<Text>().text = "Pozostałe życia: " + lifes.GetLifes();
        }
        else
        {
            lifes.ResetMyLifes();
            SceneManager.LoadScene("Menu");
        }
    }
}
