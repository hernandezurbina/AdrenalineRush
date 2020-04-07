using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMonsters : MonoBehaviour
{
    public GameObject[] monstersArray;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < Random.Range(700,900); i++) {
            monsterCount();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void monsterCount() {
        int monsterIdx = Random.Range(0, monstersArray.Length);
        GameObject randMonster = Instantiate(monstersArray[monsterIdx]);
        randMonster.transform.parent = transform;
        randMonster.transform.localPosition = new Vector3(Random.Range(-95, 95), 0.0f, Random.Range(-95, 95));
    }
}
