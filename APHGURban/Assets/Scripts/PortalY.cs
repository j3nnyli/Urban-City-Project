using UnityEngine;
using System.Collections;

public class PortalY : MonoBehaviour {
	
	public GameObject PortalB;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void OnTriggerEnter( Collider col)
	{
		if ( col.transform.CompareTag("Player"))
		{
			col.transform.position = PortalB.transform.position + new Vector3(0, 2, 0) + this.transform.forward; 	
		}
	}
}