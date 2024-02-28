using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class CodeNumbers : MonoBehaviour
{
   
    //variables FOR Generation Code
    private int GenerationCode;
    public string GenerationCodeText;
    
    void Start()
    {
        GenerationNumber();
    }
   public void GenerationNumber()
   {
       GenerationCode = Random.Range(10000, 99999);
        
       Debug.Log(GenerationCode);
       GenerationCodeText = GenerationCode.ToString();
       
   }

 
}
