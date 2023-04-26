using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StadisticPlayer : MonoBehaviour
{
    public int health = 30;
    public int vigor = 40;

    public void PlayerDies()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("Main");
        }
    }
}
