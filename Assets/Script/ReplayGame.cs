using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class ReplayGame : MonoBehaviour
{
    [SerializeField] private float pressDuration = 0.1f;
    [SerializeField] private Vector3 pressScale = new Vector3(0.9f, 0.9f, 0.9f);
    public void ReplayGames()
    {
        ButtonPressAnimation();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    
    public void ExitGames()
    {
        ButtonPressAnimation();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
    
    public void PlayGames()
    {
        ButtonPressAnimation();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    
       public void ButtonPressAnimation()
    {
        transform.DOScale(pressScale, pressDuration).SetEase(Ease.OutBack)
            .OnComplete(() => transform.DOScale(Vector3.one, pressDuration));
    }
  
}
