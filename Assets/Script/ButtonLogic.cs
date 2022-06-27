using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLogic : MonoBehaviour
{
    public bool isClickLogic;
    public static ButtonLogic buttonLogic_sing;
    private void Start()
    {
        buttonLogic_sing = this;
    }
}
