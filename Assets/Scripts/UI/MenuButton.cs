using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuButton : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField] MenuButtonController menuButtonController;
    [SerializeField] ButtonAnimation buttonAnimation;
    [SerializeField] int thisIndex;
    [SerializeField] MenuFunctions menuFunctions;

    void Update()
    {
        if (menuButtonController.index == thisIndex){
            if (Input.GetAxis("Submit") == 1){
                buttonAnimation.PressButton(this.gameObject);
                menuFunctions.AtPressButton(thisIndex);
            }else{
                buttonAnimation.SelectButton(this.gameObject);
            }
        }else if(Input.GetAxis("Vertical") != 0){
            buttonAnimation.disableOnce = true;
            buttonAnimation.DeselectButton(this.gameObject);
        }
    }

    // If click is made in button
    public void OnPointerDown(PointerEventData eventData) {
        buttonAnimation.disableOnce = true;
        buttonAnimation.PressButton(this.gameObject);
        menuFunctions.AtPressButton(thisIndex);
    }

    public void OnPointerEnter(PointerEventData eventData)
     {

        buttonAnimation.disableOnce = true;
        buttonAnimation.SelectButton(this.gameObject);
     }
 
     public void OnPointerExit(PointerEventData eventData)
     {
        buttonAnimation.disableOnce = true;
        buttonAnimation.DeselectButton(this.gameObject);
     }
}
