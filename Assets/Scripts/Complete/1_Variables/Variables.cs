using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {

    // Typical Data Types
    public int Age;
    public float Height;
    public bool isHappy;
    public string[] firstName = { "Kojo", "Timothy" };

    // Unity Data Types
    
    public GameObject player;
    public Transform playerPosition;
    public Animator playerAnimation;
    public Rigidbody playerPhysics;



    // Use this for initialization
	void Start () {
        playerPhysics.useGravity = false;
        playerPosition.position = new Vector3(0, 3.0f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
