using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomForest : MonoBehaviour
{
    public GameObject[] forestArray;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Random.Range(700, 800); i++)
        {
            forestCount();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    void forestCount()
    {
        int forestIdx = Random.Range(0, forestArray.Length);
        GameObject randForest = Instantiate(forestArray[forestIdx]);
        randForest.transform.parent = transform;
        randForest.transform.localPosition = new Vector3(Random.Range(-95, 95), 0.0f, Random.Range(-95, 95));
    }
}
