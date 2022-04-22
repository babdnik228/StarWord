using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour
{
    [SerializeField] private string _nameScene;
    public void ClickToScene()
    {
        SceneManager.LoadScene(_nameScene);
    }
}
