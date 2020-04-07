using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public int speed = 3;
    public bool moveForward = false;

    public int count;
    public Text ctext;

    // Start is called before the first frame update
    void Start()
    {
        count = 13;
        counter();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            moveForward = !moveForward;
        }
        if (moveForward) {
            transform.position = transform.position + (Camera.main.transform.forward * speed * Time.deltaTime); 
        }

        if(transform.position.y < -15) {
            SceneManager.LoadScene("PlankWalk");  
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CubeTags")) {
            count -= 1;
            counter();
            Destroy(other.gameObject); 
        }

        if(count == 0) {
            ctext.text = "Go for the trophy!";
        }

        if (count == 0 && other.gameObject.CompareTag("TrophyTag")) {
            SceneManager.LoadScene("MonsterHunt");
        }
    }

    public void counter() {
        ctext.text = "COUNT: " + count.ToString();
    }
}
