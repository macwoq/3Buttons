using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class popUpButton : MonoBehaviour
{
    Animator anim;
    [SerializeField] GameObject popUp;
    [SerializeField] GameObject blocker;

    // Start is called before the first frame update
    void Start()
    {
        blocker.SetActive(false);
        popUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivatePopUp()
    {
        if (!popUp.activeInHierarchy)
        {
            blocker.SetActive(true);
            popUp.SetActive(true);
        }
        else
        {

            return;
        }
    }

    public bool IsMouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject(popUp);
    }

    public void PopDown()
    {
        blocker.SetActive(false);
        anim = GameObject.Find("POPUP").GetComponent<Animator>();
        anim.SetBool("GoDown", true);
        StartCoroutine(PopActive());
    }

    IEnumerator PopActive()
    {
        yield return new WaitForSeconds(.5f);
        if (popUp.activeInHierarchy)
        {
            popUp.SetActive(false);
        }
    }

}
