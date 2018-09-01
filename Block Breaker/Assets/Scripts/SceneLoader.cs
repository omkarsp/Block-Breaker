using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public void LoadNextScene()
    {
         int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
        FindObjectOfType<GameStatus>().ResetGame();
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadLevel4()
    {
        SceneManager.LoadScene(5);
    }

    public void LoadLevel5()
    {
        SceneManager.LoadScene(6);
    }

    public void LoadLevel6()
    {
        SceneManager.LoadScene(7);
    }

    public void LoadLevel7()
    {
        SceneManager.LoadScene(8);
    }

    public void LoadLevel8()
    {
        SceneManager.LoadScene(9);
    }

    public void LoadLevel9()
    {
        SceneManager.LoadScene(10);
    }

    public void LoadLevel10()
    {
        SceneManager.LoadScene(11);
    }
    public void LoadLevelMenu()
    {
        SceneManager.LoadScene(1);//To load level menu
    }
}