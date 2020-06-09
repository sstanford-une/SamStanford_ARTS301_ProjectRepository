using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRadius : MonoBehaviour
{
    public GameObject artObject;
    public FMOD.Studio.EventInstance Music, Room, Blue1, Blue2, Blue3, Blue4, Purple1, Purple2, Purple3, Purple4, Green1, Green2, Green3, Green4, Orange1, Orange2, Orange3, Orange4;
    public bool active;
    string artName;
    string triggerName;

    // Start is called before the first frame update
    void Start()
    {
        TriggerCapture();
        SetValues();
        StartPlayback();
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

    void SetValues()
    {
        Room = FMODUnity.RuntimeManager.CreateInstance("event:/Room");
        Blue1 = FMODUnity.RuntimeManager.CreateInstance("event:/B1");
        Blue2 = FMODUnity.RuntimeManager.CreateInstance("event:/B2");
        Blue3 = FMODUnity.RuntimeManager.CreateInstance("event:/B3");
        Blue4 = FMODUnity.RuntimeManager.CreateInstance("event:/B4");
        Green1 = FMODUnity.RuntimeManager.CreateInstance("event:/G1");
        Green2 = FMODUnity.RuntimeManager.CreateInstance("event:/G2");
        Green3 = FMODUnity.RuntimeManager.CreateInstance("event:/G3");
        Green4 = FMODUnity.RuntimeManager.CreateInstance("event:/G4");
        Purple1 = FMODUnity.RuntimeManager.CreateInstance("event:/P1");
        Purple2 = FMODUnity.RuntimeManager.CreateInstance("event:/P2");
        Purple3 = FMODUnity.RuntimeManager.CreateInstance("event:/P3");
        Purple4 = FMODUnity.RuntimeManager.CreateInstance("event:/P4");
        Orange1 = FMODUnity.RuntimeManager.CreateInstance("event:/O1");
        Orange2 = FMODUnity.RuntimeManager.CreateInstance("event:/O2");
        Orange3 = FMODUnity.RuntimeManager.CreateInstance("event:/O3");
        Orange4 = FMODUnity.RuntimeManager.CreateInstance("event:/O4");

    }

    void StartPlayback()
    {
        Room.start();
        Blue1.start();
        Blue2.start();
        Blue3.start();
        Blue4.start();
        Green1.start();
        Green2.start();
        Green3.start();
        Green4.start();
        Purple1.start();
        Purple2.start();
        Purple3.start();
        Purple4.start();
        Orange1.start();
        Orange2.start();
        Orange3.start();
        Orange4.start();
    }
}
