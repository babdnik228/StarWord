using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviourPunCallbacks
{
    private PhotonView _photonCamera;
    private void Start()
    {
        _photonCamera = GetComponent<PhotonView>();
    }
    private void Update()
    {
        if (!_photonCamera.IsMine) return;
    }
}
