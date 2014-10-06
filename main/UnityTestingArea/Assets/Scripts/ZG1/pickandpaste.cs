using UnityEngine;
using System.Collections;

public class pickandpaste : MonoBehaviour {

	public UITexture[] bluecirtext;
	public Texture selectedtext;
	public int textcounter = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void textinplace ()
	{
		bluecirtext[textcounter].mainTexture = selectedtext;
		textcounter++;
	}

}
