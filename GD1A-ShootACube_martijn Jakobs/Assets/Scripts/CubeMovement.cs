using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float movementSpeed = 1;

    private void Update()
    {
        transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
    }
    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.tag == "Bullet")
        {

            GameObject.Destroy(other.gameObject);
        }
    }
}
