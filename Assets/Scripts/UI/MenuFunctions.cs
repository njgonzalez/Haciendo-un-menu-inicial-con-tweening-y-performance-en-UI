using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuFunctions : MonoBehaviour
{

    [SerializeField] SceneController sceneController;

    public void AtPressButton(int indexButton){
        
        if (indexButton == 0)
        {
            //Play game
            sceneController.GoToScene(1);
        }else if(indexButton == 1){
            //Exit
            sceneController.ExitApplication();
        }
    }

}
