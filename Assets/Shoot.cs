using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float pissOffset = .8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            GameObject bullet = GameObject.Instantiate(bulletPrefab);
            bullet.transform.position = transform.position + transform.forward * pissOffset;
            BulletController bulletController = bullet.GetComponent<BulletController>();
            bulletController.SetDirection(transform.forward);
            bulletController.speed = bulletController.baseSpeed * Random.Range(0.05f, 1.0f);
        }
    }
}
