using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float speedPerSecond = 1.0f;
    [SerializeField] private float moveTime = 1.0f;
    [SerializeField] private float stopTime = 1.0f;
    private float timeCount = 0.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.timeCount += Time.deltaTime;
        if (this.timeCount < this.moveTime)
        {
            this.transform.position += this.transform.forward * this.speedPerSecond * Time.deltaTime;
        }
        if (this.timeCount > this.moveTime + this.stopTime)
        {
            this.timeCount = 0.0f;
            this.transform.Rotate(0.0f, Random.Range(-180.0f, 180.0f), 0.0f);
        }
    }
}
