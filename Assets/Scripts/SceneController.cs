using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public void GoToScene(int index){
        SceneManager.LoadScene(index);
    }

    public void ExitApplication(){
        Application.Quit();
        Debug.Log("Quit");
    }

}
