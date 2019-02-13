using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables_Example : MonoBehaviour
{
    // Standard Data Types with a PUBLIC Access Modifier that makes variable visible in the inspector and accessible to outsibe scripts
    public string playerName;           // String types allow the use of characters
    public int gameLevel = 1;           // Integer types allow the use of whole numbers
    public float defaultSpeed = 10.0f;  // Float types are numbers that have have decimals. Be sure to append each float number with the letter 'f' to not get an error
    public bool isGameActive;           // Boolean types only take in two values 'true' or 'false'

    // Standard Data Types with a PRIVATE Access Modifier that makes variable only accessible WITHIN the script and NOT VISIBLE in the Unity Inspector

    // Other Variable types seen in Unity
    public Vector3 playerStartPosition = new Vector3(0, 1.0f, 0);
    public Transform playerPosition;
    public Rigidbody playerRigidbody;
    public Renderer playerRenderer;

    private void Awake()
    {
        isGameActive = true;
        Debug.Log("Level: " + gameLevel + " is active.");
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.position = playerStartPosition;  //Using the value I assigned for the variable

        playerRenderer = this.gameObject.GetComponent<Renderer>();
        playerPosition = this.gameObject.GetComponent<Transform>();

        playerRenderer.material.color = Color.cyan;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
