using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class selection : MonoBehaviour
{
    
    [SerializeField] GameObject CamControler;
    [SerializeField] GameObject SelectionUI;
    [SerializeField] GameObject ControlText;
    [SerializeField] GameObject ExploreForests;
    [SerializeField] GameObject ForestsObject;
    [SerializeField] AudioSource Click;

    public void Forests()
    {
        Click.Play();
        CamControler.SetActive(true);
        SelectionUI.SetActive(false);
        ControlText.SetActive(false);
        ExploreForests.SetActive(true);
        ForestsObject.SetActive(true);
    }
   
}
