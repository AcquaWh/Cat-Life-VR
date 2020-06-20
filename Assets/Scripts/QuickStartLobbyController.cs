using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class QuickStartLobbyController : MonoBehaviourPunCallbacks
{
    [SerializeField]
    int roomSize;
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }
    public void QuickStart()
    {
        PhotonNetwork.JoinRandomRoom();
    }
    public void CreateRoom()
    {
        int randomNumber = Random.Range(0, 1000);
        RoomOptions roomOps = new RoomOptions()
        {
            IsVisible = true,
            IsOpen = true,
            MaxPlayers = (byte)roomSize
        };

        PhotonNetwork.CreateRoom($"Room{randomNumber}", roomOps);
    }
    public override void OnJoinRandomFailed(short retunCode, string mesage)
    {
        CreateRoom();
    }
    public override void OnCreateRoomFailed(short retunCode, string mesage)
    {
        CreateRoom();
    }
    public void QuickCancel()
    {
        PhotonNetwork.LeaveRoom();
    }
}
