using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletMovement : MonoBehaviour
{
    public int speed;
    public Text uiText;
    public int score;

    private void Start()
    {
        UpdateUI();
    }
   
    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.tag == "Cube")
        {
            Plusone();
            GameObject.Destroy(other.gameObject);
        }
    }
    private void Plusone()
    {
        
        score++;

        if (score == 10)
        {
            speed = 10;
        }
        UpdateUI();
        
        
    }

    private void UpdateUI()
    {
        uiText.text = "Score: " + score.ToString();
    }
    


// Update is called once per frame
void Update () {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
