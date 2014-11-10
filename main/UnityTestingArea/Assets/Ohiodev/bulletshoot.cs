using UnityEngine;
using System.Collections;

public class bulletshoot : MonoBehaviour {

	public GameObject bullet;

	public float bulletspeed;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	

	 if(Input.GetKeyDown(KeyCode.F))
		   {
			GameObject bulletout;

			bulletout = Instantiate(bullet,transform.position,transform.rotation) as GameObject;
			bulletout.gameObject.rigidbody.AddForce(Vector3.forward *bulletspeed,ForceMode.Acceleration);
		}
	}
}
