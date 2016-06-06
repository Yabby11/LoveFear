using UnityEngine;
using System.Collections;

public class MovieTexturePlay : MonoBehaviour {

   public MovieTexture movie;

	// Use this for initialization
	void Start () {

        MovieTexture movie = GetComponent<Renderer>().material.mainTexture as MovieTexture;
        movie.Play();

        movie.loop = true;
  

	}
	
	// Update is called once per frame
	void Update () {

	}
}
