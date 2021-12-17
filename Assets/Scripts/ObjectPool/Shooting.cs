using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private float delay = 0.5f;
    [SerializeField] private GameObject bullet;
    GameObject bullet1;
    private float lastTime;


    private void Update()
    {
        if (Time.time - lastTime > delay)
        {
            if (Input.GetKey(KeyCode.Space))
                SpawnBombFromPool();
        }
        if (bullet1 != null)
            bullet1.GetComponent<Rigidbody>().velocity = transform.forward * 20;
    }

    private void SpawnBomb()
    {
        lastTime = Time.time;
        Vector3 position = transform.position;
        var bullet1 = Instantiate(bullet, position, Quaternion.identity);
    }

    private void SpawnBombFromPool()
    {
        lastTime = Time.time;
        Vector3 position = transform.position;
        bullet1 = BasicPool.Instance.getAPool();
        bullet1.transform.position = position;
    }
}