using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Reflection;

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

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Call {MethodBase.GetCurrentMethod().Name}");
        Debug.Log($"hit {other.tag}!!");

        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
