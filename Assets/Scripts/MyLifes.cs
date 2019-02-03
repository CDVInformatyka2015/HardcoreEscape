using UnityEngine;

public class MyLifes : MonoBehaviour
{
    private int _lifes = 3;

    public int GetLifes()
    {
        return _lifes;
    }

    public bool RemoveLife()
    {
        if (_lifes > 0)
        {
            _lifes--;
            return true;
        }

        return false;
    }

    public void ResetMyLifes()
    {
        _lifes = 3;
    }
}