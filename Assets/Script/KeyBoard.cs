using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
using UnityEngine.UIElements;

public class KeyBoard : MonoBehaviour
{
    [SerializeField] private Colorchange ColorControl;

    [Header("Menu manage")] 
    
    [SerializeField] private GameObject MeinMenu;
    [SerializeField] private GameObject MiniMenu;

    
    
    //Variables for chance
    
    private int chance=10;
    [SerializeField] private CodeNumbers GenCODE;
    
    //variables for TMP_TEXT
    [SerializeField] private TMP_Text TMPCodeText;
    [SerializeField] private TMP_Text TMPchanceText;
    [SerializeField] private TMP_Text TMPResultText;
    
    
    //variables For Kayboard
    [SerializeField] private int KayBoarNumber;
    
    //particl
    [SerializeField] private GameObject particle;
    
    /////////////////////ANIMATION////////////////////////
    [Header("ANIMATIONS")]

    //Shake animation
    [Header("Shake Animation")]
    
    [SerializeField] private GameObject ShakeObject,ShakeObject1;
    [SerializeField] private float shakeDuration = 0.2f;
    [SerializeField] private float shakeStrength = 0.2f;

    [Header("Button Press Animation")] 
    [SerializeField] private float pressDuration = 0.1f;
    [SerializeField] private Vector3 pressScale = new Vector3(0.9f, 0.9f, 0.9f);

    [Header("Scatter Animation")]
    [SerializeField] private GameObject ScatterObject;
    [SerializeField] private float moveDistance = 2f;
    [SerializeField] private float animationDuration = 2f;
    [SerializeField] private float NextanimationDuration = 2f;
    


   
    public void checkNumber()
    {
        if (TMPCodeText.text == GenCODE.GenerationCodeText && chance >0 && TMPCodeText.text.Length ==5 )
        {
            Debug.Log("gamoicani cifri");
            TMPResultText.text = "You Win 20$";
            chance--;
            ShakeObjectAnimation();
            TMPchanceText.text = chance.ToString();
            particle.SetActive(true);
            MeinMenu.SetActive(false);
            MiniMenu.SetActive(true);
        }else if (TMPCodeText.text != GenCODE.GenerationCodeText && chance>0 && TMPCodeText.text.Length ==5)
        {
            Debug.Log("ver gamoicani cifri");
            TMPCodeText.text = "";
            chance--;
            ColorControl.ColorChange();
            ShakeObjectAnimation();
            ShakeObject1.transform.DOShakePosition(shakeDuration, shakeStrength);
            TMPchanceText.text = chance.ToString();
            
        }else if (TMPCodeText.text.Length <5)
        {
            Debug.Log("minimum 5 cifri unda sheiyvanot");
            ScatterAnimation();
        }else if (chance <= 0)
        {
            Debug.Log("luzerr");
            TMPResultText.text = "You lOST";
            MiniMenu.SetActive(false);
            MiniMenu.SetActive(true);
        }
        ButtonPressAnimation();
    }
    
    public void KayBoard()
    {
        if (TMPCodeText.text.Length < 5)
        {
            TMPCodeText.text = TMPCodeText.text + KayBoarNumber;
            
        }
        ButtonPressAnimation();
    }

    public void ExitButton()
    {
        TMPCodeText.text = "";
        ButtonPressAnimation();
        ShakeObjectAnimation();
    }

    public void ShakeObjectAnimation()
    {
        ShakeObject.transform.DOShakePosition(shakeDuration, shakeStrength);
        
    }
    
  

    public void ButtonPressAnimation()
    {
        transform.DOScale(pressScale, pressDuration).SetEase(Ease.OutBack)
            .OnComplete(() => transform.DOScale(Vector3.one, pressDuration));
    }

    public void ScatterAnimation()
    {
        
        ScatterObject.transform.DOMoveY(ScatterObject.transform.position.y + moveDistance, animationDuration).SetDelay(NextanimationDuration).OnComplete(ScatterDefault);
    }

    public void ScatterDefault()
    {
        ScatterObject.transform.DOMoveY(this.ScatterObject.transform.position.y - moveDistance, animationDuration);
    }

   

   

  
}
