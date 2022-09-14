using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public void restart()
    {
        gamecontroller.game_over = false;
        SceneManager.LoadScene(0);
    }

}
