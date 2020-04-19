using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRadius : MonoBehaviour
{
    public GameObject artObject;
    public bool active;
    string artName;
    string triggerName;

    // Start is called before the first frame update
    void Start()
    {
        TriggerCapture();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TriggerCapture()
    {
        artName = artObject.name;
        triggerName = (artName + "." + gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        active = true;
        Debug.Log(triggerName + " activated.");
    }

    private void OnTriggerExit(Collider other)
    {
        active = false;
        Debug.Log(triggerName + " deactivated.");
    }
}
