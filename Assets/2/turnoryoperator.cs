using UnityEngine;
using System.Collections;

public class turnoryoperator : MonoBehaviour {

    int health = 9;

	// Use this for initialization
	void Start () {
        string message;

        message = health > 0 ? "Alive" : "dead";

        Debug.Log("Status: " + message);

        message = health < 10 ? "ITS JUST A FLESH WOUND" : "For Asguard!";
        Debug.Log(message);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
