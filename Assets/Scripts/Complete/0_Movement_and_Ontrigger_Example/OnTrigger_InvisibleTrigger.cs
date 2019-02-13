using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger_InvisibleTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // Scales the player to a larger size when it enters the invisible trigger zone
            other.transform.localScale = new Vector3(8.0f, 8.0f,8.0f);

            //float yPosition = other.transform.localScale.y * 0.5f;

            // Makes sure that the player sits on the floor at its present scale
            other.transform.localPosition = new Vector3(other.transform.localPosition.x, 4.0f, other.transform.localPosition.z);

            // Change the player color to yellow
            other.GetComponent<Renderer>().material.color = Color.yellow;
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            // Returns the player scale back to its original form after exiting the invisible trigger zone
            other.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);

            // Makes sure that the player sits on the floor at its present scale
            other.transform.localPosition = new Vector3(other.transform.localPosition.x, 1.0f, other.transform.localPosition.z);

            // Change the player color back to blue
            other.GetComponent<Renderer>().material.color = Color.blue;
        }
    }

}
