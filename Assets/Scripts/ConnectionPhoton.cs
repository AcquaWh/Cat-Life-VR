using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class ConnectionPhoton : MonoBehaviour
{
    [SerializeField]
    QuickStartLobbyController quickStartLobby;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

}
