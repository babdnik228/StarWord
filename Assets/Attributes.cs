using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour
{
    [SerializeField] private Leader leader;
    public int diplomaticus;
    public int administrius;
    public int voenus;
    
    private void FixedUpdate()
    {
        diplomaticus += leader.characteristic_diplomatic;
        administrius += leader.characteristic_administraunion;
        voenus += leader.characteristic_voen;
    }
}
