using UnityEngine;
using System.Collections;

public class DoNotDestroy : MonoBehaviour {
    public GameObject self;

	// Use this for initialization
	void Awake () {

        DontDestroyOnLoad(self);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
