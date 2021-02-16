using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextButton : MonoBehaviour
{

    public string displayedText;
    Text exampleText;
    public float timeToDisplay;

    [Header("Toggle PostProcessing")]
    [SerializeField] GameObject postPro;

    // Start is called before the first frame update
    void Start()
    {
        exampleText = GameObject.Find("ExampleText").GetComponent<Text>();

        exampleText.text = displayedText;
        exampleText.gameObject.SetActive(false);
    }


    public void DisplayText()
    {
        
        exampleText.gameObject.SetActive(true);
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        yield return new WaitForSeconds(timeToDisplay);
        exampleText.gameObject.SetActive(false);
        
    }
    public void UsePost(bool post)
    {
        if (post)
        {
            postPro.SetActive(true);
        }
        else if(!post)
        {
            postPro.SetActive(false); 
        }
    }
}
