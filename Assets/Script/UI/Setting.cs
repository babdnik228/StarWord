using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    [SerializeField] private GameObject panel_setting;
    [SerializeField] private GameObject music;
    [SerializeField] private bool isMusic;
    public void ClickSetting()
    {
        panel_setting.SetActive(true);
    }
    public void ExitSetting()
    {
        panel_setting.SetActive(false);
    }
    public void MusicClick()
    {
        if (isMusic == false)
        {
            isMusic = true;
        }
        else if (isMusic == true)
        {
            isMusic = false;
        }

        if (isMusic == true)
        {
            music.SetActive(true);
        }
        if (isMusic == false)
        {
            music.SetActive(false);
        }
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void HowPlay()
    {

    }
}
