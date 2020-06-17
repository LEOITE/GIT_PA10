using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn_restart : MonoBehaviour
{
    public void restartgame()
    {
        SceneManager.LoadScene("Gamegame");
    }
}
