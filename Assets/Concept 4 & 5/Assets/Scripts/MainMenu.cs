using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject Information;
    [SerializeField] GameObject SettingTab;
    [SerializeField] GameObject SelectionUI;
    [SerializeField] GameObject ControlText;
    [SerializeField] GameObject worldCanvas;
    [SerializeField] AudioSource Click;

    public void RestartGame()
    {
        Click.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ShowInformation()
    {
        Click.Play();
        if(Information.activeSelf)
        {
            Information.SetActive(false);
            if(SelectionUI.activeSelf)
                ControlText.SetActive(true);
        }
        else
        {
            Information.SetActive(true);
            ControlText.SetActive(false);
        }
    }

    public void CloseInformation()
    {
        Click.Play();
        Information.SetActive(false);
        if(SelectionUI.activeSelf)
            ControlText.SetActive(true);
    }

    public void ShowSettingTab()
    {
        Click.Play();
        if(SettingTab.activeSelf)
        {
            SettingTab.SetActive(false);
            if(SelectionUI.activeSelf)
                ControlText.SetActive(true);
        }
        else
        {
            SettingTab.SetActive(true);
            ControlText.SetActive(false);
        }
    }

    public void CloseSettingTab()
    {
        Click.Play();
        SettingTab.SetActive(false);
        if(SelectionUI.activeSelf)
            ControlText.SetActive(true);
    }

    public void Eye()
    {
        Click.Play();

        GameObject ui = GameObject.FindGameObjectWithTag("Model");
        if(worldCanvas.transform.childCount > 0)
        {
            GameObject uiText = worldCanvas.transform.GetChild(0).gameObject;
            if(uiText.activeSelf)
            {
                uiText.transform.SetParent(ui.transform);
                uiText.transform.SetAsFirstSibling();
                uiText.SetActive(false);
            }
        }
        else
            ui.transform.GetChild(0).gameObject.SetActive(true);
    }
}