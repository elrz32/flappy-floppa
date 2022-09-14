using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bingus : MonoBehaviour
{
    bool contato = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gamecontroller.game_over!=true)
            transform.position = new Vector2(transform.position.x - 1.5f * Time.deltaTime, transform.position.y);
            if (transform.position.x < -8f)
                Destroy(gameObject);
             if (!contato && transform.position.x < -4)
             {
                contato = true;
                socre.score_game += 1;
             }
                 

                

    }
}
