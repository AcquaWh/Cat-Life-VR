using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class ConnectionPhoton : MonoBehaviourPunCallbacks
{
    [SerializeField]
    QuickStartLobbyController quickStartLobby;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log($"Connected to {PhotonNetwork.CloudRegion} server");
        quickStartLobby.QuickStart();
    }
}
