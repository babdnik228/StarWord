using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputClickToSceme : MonoBehaviour
{
    [SerializeField]
    private int _nameScene;
    [SerializeField]
    private GameObject _buttonIcon;
    [SerializeField]
    private GameObject _animation;

    private void OnTriggerStay(Collider other)
    {
        PlayerManager character = other.GetComponent<PlayerManager>();
        if(character != null)
        {
            _buttonIcon.SetActive(true);
            if(character && Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(Cor());
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        PlayerManager character = other.GetComponent<PlayerManager>();
        if (character != null)
        {
            _buttonIcon.SetActive(false);
        }
    }
    private IEnumerator Cor()
    {
        yield return new WaitForSeconds(1);
        _buttonIcon.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        _animation.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(_nameScene);
    }
    
}
