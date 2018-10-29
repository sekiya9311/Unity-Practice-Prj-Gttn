using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    [SerializeField] private float speedPerSecond = 3.0f;
    [SerializeField] private float life = 5.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speedPerSecond * Time.deltaTime;
        life -= Time.deltaTime;
        if (life <= 0.0f)
        {
            Destroy(this.gameObject);
            return;
        }
    }
}
