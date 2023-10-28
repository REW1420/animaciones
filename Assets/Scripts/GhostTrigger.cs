using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class GhostTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ghost") == true)
        {
            Debug.Log("Trigger activado por: " + other.name);
        }
        else
        {
            Debug.Log("no coliciona nada");
        }



    }
}
