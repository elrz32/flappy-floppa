using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class socre : MonoBehaviour
{
    public static int score_game;
    // Start is called before the first frame update
    void Start()
    {
        score_game = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = score_game.ToString();
    }
}
