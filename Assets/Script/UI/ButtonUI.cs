using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] private GameObject music;
    [SerializeField] private GameObject BlackEnd;

    public void ClickScene()
    {
        
        StartCoroutine(CorLogic());
    }
    private IEnumerator CorLogic()
    {Instantiate(music, transform.position, Quaternion.identity);
        BlackEnd.SetActive(true);
        yield return new WaitForSeconds(2.2f);
        SceneManager.LoadScene(1);
    }
}
