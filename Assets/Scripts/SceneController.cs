using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void MainMenu(){
        SceneManager.LoadScene("AREncyclopedia");
    }
    public void ARScene(){
        //this is the name of the actual scene that we have created and named it as
        SceneManager.LoadScene("ARDino");
    }
    public void QuitApp(){
        Application.Quit();
    }
}
