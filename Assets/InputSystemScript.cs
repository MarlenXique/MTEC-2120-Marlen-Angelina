using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;


public class NewBehaviourScript : MonoBehaviour
{
    public GameObject mainTree;

    // Update is called once per frame
    public void OnFire(InputAction.CallbackContext context)
    {
        //mainTree.GetComponent<Rigidbody>().material.color = Color.red;
        Debug.Log("Test");
    
    }

}
