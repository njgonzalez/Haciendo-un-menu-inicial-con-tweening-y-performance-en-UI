using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAnimation : MonoBehaviour
{

    public AudioClip audioSelection;
    public AudioClip audioPressed;

    public bool disableOnce;
    public void PressButton(GameObject gameObject){
        if (disableOnce){ 
            if (!LeanTween.isTweening(gameObject)){
                LeanTween.scale(gameObject, new Vector3(0.7f, 0.7f, 1f), 0.2f).setLoopPingPong(1).setEase(LeanTweenType.easeInOutCirc);
                LeanAudio.play(audioPressed, 0.5f);
                this.disableOnce = false;
            }
        }
    }

    public void SelectButton(GameObject gameObject){
        if (disableOnce){
            if (gameObject.GetComponent<Image>().color == Color.black){
                gameObject.GetComponent<Image>().color = Color.Lerp(Color.black, Color.white, 1f);
                LeanAudio.play(audioSelection, 0.5f);
                // Debug.Log (gameObject.name + " Was entered");
                this.disableOnce = false;  
            }
        }
    }

    public void DeselectButton(GameObject gameObject){
        if (disableOnce){
            if (gameObject.GetComponent<Image>().color == Color.white){
                gameObject.GetComponent<Image>().color = Color.Lerp(Color.white, Color.black, 1f);
                // Debug.Log (gameObject.name + " Was exited");
                this.disableOnce = false;  
            }   
        }
    }
}
