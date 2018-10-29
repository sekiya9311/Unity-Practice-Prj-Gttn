using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using System.Linq;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float speedPerSecond = 1.0f;
    private int cntEven = 5;
    private Vector3[] vec3Dirs = { new Vector3(1, 0, 0), new Vector3(0, 1, 0), new Vector3(0, 0, 1) };
    private int dirsCnt = 0;
    [SerializeField] private GameObject bulletPrefab = null;
    [SerializeField] private Transform muzzle = null;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var dir = this.InputToMove();
        if (dir.magnitude > 0.0f)
        {
            this.Move(dir);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            this.ShootBullet();
        }

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

    /// <summary>
    /// キーボードの入力({WASD} or {←↑↓→})をもとにして移動処理を行います．
    /// </summary>
    private Vector3 InputToMove()
        => new Vector3() { x = Input.GetAxis("Horizontal"), z = Input.GetAxis("Vertical") };

    /// <summary>
    /// 引数で受け取った移動方向に移動します．
    /// </summary>
    /// <param name="moveDirection">移動方向</param>
    private void Move(Vector3 moveDirection)
    {
        this.transform.position += moveDirection.normalized * this.speedPerSecond * Time.deltaTime;
        this.transform.rotation = Quaternion.LookRotation(moveDirection); // オブジェクトの向きが進行方向に変わる!!
    }

    /// <summary>
    /// 弾の発射を行います．
    /// </summary>
    private void ShootBullet()
    {
        Debug.Log($"Call {MethodBase.GetCurrentMethod().Name}");
        if (!this.bulletPrefab)
        {
            Debug.LogWarning($"Please set Bullet as {nameof(this.bulletPrefab)} !!");
            return;
        }
        if (!this.muzzle)
        {
            this.muzzle = this.transform;
        }
        Instantiate(this.bulletPrefab, this.muzzle.position, this.muzzle.rotation);
    }
}
