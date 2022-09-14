using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour
{
    float spawntimer;
    float spawnrate = 3f;
    public GameObject binguss;
    public static bool game_over;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!game_over)
            spawntimer += Time.deltaTime;
             if (spawntimer > spawnrate)
             {
                spawntimer -= spawnrate;
                Vector2 spawnposizione = new Vector2(2f, Random.Range(-2f, 1f));
                Instantiate(binguss, spawnposizione, Quaternion.identity);

             }
    }
}
