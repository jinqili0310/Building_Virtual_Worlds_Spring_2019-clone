using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays_Loops_Example : MonoBehaviour
{
    public string[] buildingVirtualWorldStudents;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach(var kanyeWest in buildingVirtualWorldStudents)
        {
            Debug.Log(kanyeWest + " is a student in the class.");

            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
