using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject targetGameObject;
    public void ToggleTheTarget()
    {
        targetGameObject.SetActive(!targetGameObject.activeSelf); 
    }
    // Start is called before the first frame update
    public void ExitGame()
    {
        print("Exiting");
    }
}
