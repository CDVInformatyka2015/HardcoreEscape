using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeToMenu : MonoBehaviour {

    public bool inMenu;
    public bool isActive = true;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) && isActive)
        {
            if (!inMenu)
                SceneManager.LoadScene("Menu");
            else
                SceneManager.LoadScene("SuperLabirynth");
        }
	}
}
