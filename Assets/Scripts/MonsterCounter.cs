using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public int counter;
    public TextMesh totalMonster;
    void Start()
    {
        counter = 0;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseCounter() {
        counter += 1;
        totalMonster.text = counter.ToString();
        //Debug.Log("Monsters collected: " + counter);
    }
}
