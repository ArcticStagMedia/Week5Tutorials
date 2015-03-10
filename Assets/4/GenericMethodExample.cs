using UnityEngine;
using System.Collections;

public class GenericMethodExample : MonoBehaviour {

	// Use this for initialization
	void Start () {

        GenericClass myClass = new GenericClass();

        myClass.GenericMethod<int>(5);

        Debug.Log(myClass.GenericMethod<int>(5));
        Debug.Log(myClass.Square<int>(5));
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
