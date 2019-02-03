using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Life");

        if (objs.Length > 2)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
}