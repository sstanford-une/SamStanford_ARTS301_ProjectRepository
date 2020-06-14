using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class TriggerRadius : MonoBehaviour
{
    public GameObject artObject;
    public ControlScript controlScript;
    public bool active;
    string artName;
    string triggerName;

    // Start is called before the first frame update
    void Start()
    {
        ComponentCapture();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ComponentCapture()
    {
        artName = artObject.name;
        triggerName = (artName + "." + gameObject.name);
    }
}
