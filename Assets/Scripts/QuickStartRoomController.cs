using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class QuickStartRoomController : MonoBehaviourPunCallbacks
{
    [SerializeField]
    int multiplayerSceneIndex;

    public override void OnEnable()
    {
        PhotonNetwork.AddCallbackTarget(this);
    }

    public override void OnDisable()
    {
        PhotonNetwork.RemoveCallbackTarget(this);
    }

    public override void OnJoinedRoom()
    {
        StartGame();
    }

    public void StartGame()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.LoadLevel(multiplayerSceneIndex);
        }
    }
}
