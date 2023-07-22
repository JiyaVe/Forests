using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Selection : MonoBehaviour
{
    [SerializeField] GameObject CamControler;
    [SerializeField] GameObject SelectionUI;
    [SerializeField] GameObject ControlText;
    [SerializeField] GameObject JimCorbettPark;
    [SerializeField] GameObject JimCorbettObject;
    [SerializeField] GameObject RanthamborePark;
    [SerializeField] GameObject RanthamboreObject;
    [SerializeField] AudioSource Click;

    public void JimCorbett()
    {
        Click.Play();
        CamControler.SetActive(true);
        SelectionUI.SetActive(false);
        ControlText.SetActive(false);
        JimCorbettPark.SetActive(true);
        JimCorbettObject.SetActive(true);
    }

    public void Ranthambore()
    {
        Click.Play();
        CamControler.SetActive(true);
        SelectionUI.SetActive(false);
        ControlText.SetActive(false);
        RanthamborePark.SetActive(true);
        RanthamboreObject.SetActive(true);
    }
}