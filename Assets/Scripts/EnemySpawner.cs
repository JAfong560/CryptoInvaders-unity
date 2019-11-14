using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    private Transform here;
    // Start is called before the first frame update
    void Start()
    {
        here.position = gameObject.transform.position;
        Instantiate(enemy,here,here);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
