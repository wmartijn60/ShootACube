using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDelete : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
 
        private void OnTriggerStay(Collider other)
        {
            
            if (other.gameObject.tag == "Bullet")
            {

                GameObject.Destroy(other.gameObject);
            }
        }
    
}