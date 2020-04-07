using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonstersCollected : MonoBehaviour
{

    MonsterCounter mcalc;

    void Start()
    {
        mcalc = FindObjectOfType<MonsterCounter>();
        //mcalc = MonsterCounter();
    }

    public void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.CompareTag("violetMonster")) 
        {
            Destroy(collide.gameObject);
            Destroy(gameObject);
            mcalc.increaseCounter();
        }
        if (collide.gameObject.CompareTag("cyanMonster"))
        {
            Destroy(collide.gameObject);
            Destroy(gameObject);
            mcalc.increaseCounter();
        }
        if (collide.gameObject.CompareTag("blueMonster"))
        {
            Destroy(collide.gameObject);
            Destroy(gameObject);
            mcalc.increaseCounter();
        }
        if (collide.gameObject.CompareTag("redMonster"))
        {
            Destroy(collide.gameObject);
            Destroy(gameObject);
            mcalc.increaseCounter();
        }

    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.CompareTag("ground")){
            Destroy(gameObject);
        }
    }

}
