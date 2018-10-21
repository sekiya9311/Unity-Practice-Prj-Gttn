using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] private float speedPerSecond = 2.0f;
    private int cntEven = 5;
    private Vector3[] vec3Dirs = { new Vector3(1, 0, 0), new Vector3(0, 1, 0), new Vector3(0, 0, 1) };
    private int dirsCnt = 0;

    // Use this for initialization
    void Start () {
		
	}
    
	// Update is called once per frame
	void Update ()
    {
        //this.Buruburu();
        //this.GoStraight();
        this.Fly();
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

    /// <summary>
    /// どっか飛んでく
    /// </summary>
    private void Fly()
    {
        this.transform.position += vec3Dirs[dirsCnt].normalized * speedPerSecond * Time.deltaTime;
        dirsCnt = (dirsCnt + 1) % 3;
    }
}
