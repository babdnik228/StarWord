using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMoney : MonoBehaviour
{
    public GameObject obj_act;
    private void OnMouseEnter()
    {
        
            obj_act.SetActive(true);
        
    }
    private void OnMouseExit()
    {
        
            obj_act.SetActive(false);
        
    }
}
