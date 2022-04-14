using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameServer : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private GameObject playerPrefab;
    private void Start()
    {
        Vector3 pos = new Vector3(54, 21.8753f, 12);
        PhotonNetwork.Instantiate(playerPrefab.name, pos, Quaternion.identity);
    }
    public void LeavButton()
    {
        PhotonNetwork.LeaveRoom();
    }
    public override void OnLeftRoom()
    {
        SceneManager.LoadScene(0);
    }
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.LogFormat(newPlayer.NickName);
    }
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        Debug.LogFormat(otherPlayer.NickName);
    }
}
