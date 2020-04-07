using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    MonsterCounter mcalc;
    int monsterCount = 0;
    public Text monsterText;

    // Start is called before the first frame update
    void Start()
    {
        mcalc = FindObjectOfType<MonsterCounter>();
        monsterCount = mcalc.counter;
        monsterText.text = "Score: " + monsterCount.ToString();
        Destroy(mcalc.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
