using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchClick : MonoBehaviour
{
    [SerializeField]
    private GameObject _eRestartButton;
    [SerializeField]
    private GameObject _fToGame;
    [SerializeField]
    private GameObject _animator;
    [SerializeField]
    private int _nameSceneE;
    [SerializeField]
    private int _gameScene;
    private void OnTriggerStay(Collider other)
    {
        PlayerManager playerManager = other.GetComponent<PlayerManager>();
        if(playerManager != null)
        {
            _eRestartButton.SetActive(true);
            _fToGame.SetActive(true);
            if (playerManager && Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(CorButtonE());
            }
            if (playerManager && Input.GetKeyDown(KeyCode.F))
            {
                StartCoroutine(CorButtonF());
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        PlayerManager playerManager = other.GetComponent<PlayerManager>();
        if (playerManager != null)
        {
            _eRestartButton.SetActive(false);
            _fToGame.SetActive(false);
        }
    }
    private IEnumerator CorButtonE()
    {
        yield return new WaitForSeconds(1);
        _eRestartButton.SetActive(false);
        _fToGame.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        _animator.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(_nameSceneE);
    }
    private IEnumerator CorButtonF()
    {
        yield return new WaitForSeconds(1);
        _eRestartButton.SetActive(false);
        _fToGame.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        _animator.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(_gameScene);
    }
}
