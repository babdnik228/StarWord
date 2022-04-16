using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneSpeel : MonoBehaviour
{
    [SerializeField]
    private GameObject pointAttack;
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private float powerShot;
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletPrefab, pointAttack.transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddRelativeForce(transform.localPosition * powerShot,ForceMode.VelocityChange);
        }
    }

}
