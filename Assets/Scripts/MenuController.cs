using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenueController : MonoBehaviour
{
    public GameObject menuParent;
    public KeyCode toggleKey = KeyCode.P;
    public bool hasBeenPaused = false;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            ToggleTheTarget();
        }

    }
    void ToggleTheTarget()
    {
        if (!hasBeenPaused)
        {
            hasBeenPaused = true;
            Time.timeScale = 0.0f;
        }
        else
        {
            hasBeenPaused = false;
            Time.timeScale = 1.0f;
        }
    }
}
