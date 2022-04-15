using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Character : MonoBehaviourPunCallbacks , IPunObservable
{
    private NavMeshAgent _navMeshAgent;
    private Rigidbody _rigidbody;
    [SerializeField]
    private Camera _MainCamera;
    private PhotonView _photonView;
    [SerializeField]
    private GameObject _clickEffectPrefab;
    [SerializeField]
    private Vector3 _posClickEffect;
    /*[SerializeField]
    private Canvas canvasTwo;*/
    private void Start()
    {
        _MainCamera = Camera.main;
        _rigidbody = GetComponent<Rigidbody>();
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _photonView = GetComponent<PhotonView>();
       // if (!photonView.IsMine) canvasTwo;
    }
    private void Update()
    {
        if (!_photonView.IsMine) return;
        MoveLogic(); 
    }
    private void MoveLogic()
    {   
        if (Input.GetMouseButtonDown(1))
            {
                RaycastHit hit;
                if (Physics.Raycast(_MainCamera.ScreenPointToRay(Input.mousePosition), out hit))
                {
                    GameObject effectClic = Instantiate(_clickEffectPrefab,hit.point + _posClickEffect, Quaternion.Euler(-90,0,0));
                    Destroy(effectClic, 0.4f);
                    _navMeshAgent.SetDestination(hit.point);
                }
            }   
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
       
    }
}
