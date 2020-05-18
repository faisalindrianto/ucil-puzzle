using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    public void GoToMainMenu(){
        SceneManager.LoadScene("Home");
    }

    public void ChooseLevel(){
        SceneManager.LoadScene("ChooseLevel");
    }

    public void IntoTheGame(){
        SceneManager.LoadScene("Brief");
    }

    public void IntoMainGame(){
        SceneManager.LoadScene("MainGame");
    }
}
