using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    [SerializeField]
    private GameObject Bullet;
    [SerializeField]
    private GameObject Muzzle;

    // Use this for initialization
    void ShootBullet () {
        Instantiate(Bullet, Muzzle.transform.position, transform.rotation);

    }

    // Update is called once per frameD
    void Update () {
        if (Input.GetButtonDown("Shoot"))
        {
            ShootBullet();
       
        }
    }
}
