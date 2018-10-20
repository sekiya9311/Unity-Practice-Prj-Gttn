using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] private float speedPerSecond = 2.0f;

	// Use this for initialization
	void Start () {
		
	}
    
	// Update is called once per frame
	void Update ()
    {
        Vector3 moveDirection = new Vector3(1, 0, 0);
        this.transform.position += moveDirection.normalized * speedPerSecond * Time.deltaTime;
	}
}
