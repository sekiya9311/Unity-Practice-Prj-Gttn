using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private Transform followTarget = null;
    private Vector3 cameraPosition = new Vector3();

    // Use this for initialization
    void Start()
    {
        if (this.followTarget)
        {
            this.cameraPosition = this.transform.position - this.followTarget.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.followTarget)
        {
            this.transform.position = this.followTarget.position + this.cameraPosition;
        }
    }
}
