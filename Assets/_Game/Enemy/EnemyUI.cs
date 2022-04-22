using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyUI : MonoBehaviour
{
    public Slider _helth;
    public Slider _helthMax;
    public MobClassic _mob;
    private void Update()
    {
        _helth.value = _mob._helth;
        _helthMax.maxValue = _mob._healthMax;
    }
}
