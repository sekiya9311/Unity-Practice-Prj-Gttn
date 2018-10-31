using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Linq;

public class FieldController : MonoBehaviour
{

    [SerializeField] private GameObject enemyPrefab = null;
    private IEnumerable<GameObject> enemies = null;

    // Use this for initialization
    void Start()
    {
        if (!this.enemyPrefab)
        {
            Debug.LogWarning($"Please set Bullet as {nameof(this.enemyPrefab)} !!");
            return;
        }

        this.enemies = Enumerable.Range(0, Random.Range(1, 100))
            .Select(i => Instantiate(
                this.enemyPrefab,
                new Vector3(
                    Random.Range(-20, 20),
                    0.5f,
                    Random.Range(-20, 20)),
                new Quaternion(0, 0, 0, 0))).ToList();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.enemies.All(e => e == null))
        {
            Debug.Log("CLEAR !!");
        }
    }
}
