using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUICOntroller : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("SelectLevel");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
