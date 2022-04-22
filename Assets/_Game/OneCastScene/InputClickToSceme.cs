using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputClickToSceme : MonoBehaviour
{
    [SerializeField]
    private int _nameScene;
    private void OnTriggerStay(Collider other)
    {
        PlayerManager character = other.GetComponent<PlayerManager>();
        if(character != null)
        {
            
                SceneManager.LoadScene(_nameScene);
            
        }
    }
}
