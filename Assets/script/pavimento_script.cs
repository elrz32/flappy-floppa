using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pavimento_script : MonoBehaviour
{
    Vector2 posizione_inziale;
    void Start()
    {
        posizione_inziale = transform.position;
    }
    void Update()
    {
        if(gamecontroller.game_over!=true)
            if (transform.position.x >= -0.0367f)
                //vector 2 è per un personaggio 2d, transform position è per effettuare un update della posizione
                transform.position = new Vector2(transform.position.x - 1.5f * Time.deltaTime, transform.position.y);  //0.01f perchè il numero è un float
            else
                transform.position = posizione_inziale;

    }
}
