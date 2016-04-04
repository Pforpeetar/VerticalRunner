using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    Rigidbody2D r;
	// Use this for initialization
	void Start () {
        r = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButtonDown(0))
        {
            r.velocity = new Vector3(0, 15);
        }
	}
}
