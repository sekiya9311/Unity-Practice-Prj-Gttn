using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldController : MonoBehaviour
{

    [SerializeField] private GameObject enemyPrefab = null;

    // Use this for initialization
    void Start()
    {
        if (!this.enemyPrefab)
        {
            Debug.LogWarning($"Please set Bullet as {nameof(this.enemyPrefab)} !!");
            return;
        }
        var enemCnt = Random.Range(0, 10);
        for (int i = 0; i < enemCnt; i++)
        {
            Instantiate(
                this.enemyPrefab, 
                new Vector3(
                    Random.Range(0, 10), 
                    0.5f, 
                    Random.Range(0, 10)),
                new Quaternion(0,0,0,0));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
