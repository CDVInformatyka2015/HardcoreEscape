using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLifes : MonoBehaviour
{
    private int lifes = 3;

    void Start()
    {
        Debug.LogWarning(this.lifes);
    }

    public int GetLifes()
    {
        return lifes;
    }

    public bool RemoveLife()
    {
        if (lifes > 0)
        {
            lifes--;
            return true;
        }
        return false;
    }

    public void ResetMyLifes()
    {
        lifes = 3;
    }
}