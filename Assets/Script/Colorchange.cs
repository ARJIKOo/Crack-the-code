using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Colorchange : MonoBehaviour
{
    public Color targetColor = Color.red; // Set the target color in the Inspector
    public float duration = 1.0f; // Set the duration of the color change

    private Image panelImage;
    private Color defaultColor;
    
    // Start is called before the first frame update
    void Start()
    {
        panelImage = GetComponent<Image>();
        defaultColor = panelImage.color;
    }

    public void ColorChange()
    {
        panelImage.DOColor(targetColor, duration).SetDelay(0f).OnComplete(ResetColor);
    }
    
    private void ResetColor()
    {
        panelImage.DOColor(defaultColor, duration); // Revert to default color quickly
    }
}
