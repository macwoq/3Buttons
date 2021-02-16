using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Line : MonoBehaviour
{
    private Image line;
    private Animator anim;
    [SerializeField] Button button1;
    [SerializeField] Button button2;
    [SerializeField] Button button3;

    bool isRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<Image>();
        
    }

    private void Update()
    {
        ActivateButtons();
        if (Input.GetButtonDown("Jump") && !isRunning)
        {
            isRunning = true;
            ActivateButtons();
        }
    }

    private void ActivateButtons()
    {
        if(line.fillAmount > .15f)
        { button1.gameObject.SetActive(true); }

        if (line.fillAmount > .48f)
        { button2.gameObject.SetActive(true); }

        if (line.fillAmount > .85f)
        { button3.gameObject.SetActive(true); }
    }


        
}
