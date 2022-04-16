using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoSpeel : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;
    [SerializeField]
    private GameObject point;
    
    public void ClickCas()
    {
        GameObject cubePref = Instantiate(cube, point.transform.position, Quaternion.identity);
        cubePref.GetComponent<Rigidbody>().AddForce(transform.forward * 55f);
        cubePref.transform.localScale = new Vector3(2 * 2, 2 * 2, 2 * 2);
    }
}
