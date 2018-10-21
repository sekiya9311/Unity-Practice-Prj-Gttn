using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] private float speedPerSecond = 2.0f;
    private int cntEven = 5;

	// Use this for initialization
	void Start () {
		
	}
    
	// Update is called once per frame
	void Update ()
    {
        //this.Buruburu();
        this.GoStraight();
	}

    /// <summary>
    /// どっか行きます
    /// </summary>
    private void GoStraight()
    {
        Vector3 moveDirection = new Vector3(1, 0, 0);
        this.transform.position += moveDirection.normalized * speedPerSecond * Time.deltaTime;
    }

    /// <summary>
    /// ブルブルします
    /// </summary>
    private void Buruburu()
    {
        Vector3 moveDirection = new Vector3(1, 0, 0);
        this.transform.position += moveDirection.normalized * speedPerSecond * Time.deltaTime * (cntEven *= -1);
    }
}
