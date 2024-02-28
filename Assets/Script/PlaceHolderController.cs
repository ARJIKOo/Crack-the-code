using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlaceHolderController : MonoBehaviour
{
    [SerializeField] private GameObject placeholder;
    [SerializeField] private TMP_Text TMPCodeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlaceHolderContoler();
    }
    public void PlaceHolderContoler()
    {
        if (TMPCodeText.text.Length > 0)
        {
            placeholder.SetActive(false);
        }
        else
        {
            placeholder.SetActive(true);
        }
    }
}
