using UnityEngine;
using System.Collections;

public class clickedtexture : MonoBehaviour {

	private UITexture objtext;
	public pickandpaste papinstance;

	public Texture Objtext
	{
		get
		{
			return objtext.mainTexture;
		}

		set
		{
			objtext.mainTexture = value;
		}
	}


	public void clickedon()
	{
		papinstance.selectedtext = objtext.mainTexture;
	}
}
