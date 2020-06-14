using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour
{
    GameObject[] artObjects = new GameObject[6];
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CollectArt()
    {
        int artCount = GameObject.FindGameObjectsWithTag("Artwork").Length;
        for (int i = 0; i < artCount; i++)
        {

        }
    }
}
