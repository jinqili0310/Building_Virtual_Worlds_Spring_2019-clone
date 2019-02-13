using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Example : MonoBehaviour
{
    public int colorSwitch = 1;
    public string emotion = "happy";
    public Renderer objectColor;

    void Start()
    {
        objectColor = this.gameObject.GetComponent<Renderer>();
    }

    void Update()
    {
       /* switch (colorSwitch)
        {
            case 1:
                objectColor.material.color = Color.black;
                transform.Rotate(0, 45.0f * Time.deltaTime, 0);
                break;
            case 2:
                objectColor.material.color = Color.blue;
                break;
            case 3:
                objectColor.material.color = Color.cyan;
                break;
            case 4:
                objectColor.material.color = Color.red;
                break;
            default:
                objectColor.material.color = Color.yellow;
                break;
        }
        */
        switch (emotion)
        {
            case "happy":
                objectColor.material.color = Color.black;
                transform.Rotate(0, 45.0f * Time.deltaTime, 0);
                break;
            case "sad":
                objectColor.material.color = Color.blue;
                break;
            case "angry":
                objectColor.material.color = Color.cyan;
                break;
            case "indifferent":
                objectColor.material.color = Color.red;
                break;
            default:
                objectColor.material.color = Color.yellow;
                break;
        }
    }
}
