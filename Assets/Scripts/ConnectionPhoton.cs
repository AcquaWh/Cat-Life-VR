using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
public class ConnectionPhoton : MonoBehaviourPunCallbacks
{
    /*
    [SerializeField]
    QuickStartLobbyController quickStartLobby;
    */
    public Button ConnectButton;
    public Button JoinRandomButton;
    public Text Log;
    public Text PlayerCount;
    public int playersCount;

    public byte maxPlayersPerRoom = 4;

    public void Connect()
    {
        if (!PhotonNetwork.IsConnected)
        {
            if (PhotonNetwork.ConnectUsingSettings())
            {
                Log.text = "Connected to Server";
            } else
            {
                Log.text = "Failing Connecting to Server";
            }
        }
    }

    public override void OnConnectedToMaster()
    {
        ConnectButton.interactable = false;
        JoinRandomButton.interactable = true;
    }
    public void JoinRandom()
    {
        if (!PhotonNetwork.JoinRandomRoom())
        {
            Log.text = "Fail Joining";
        }
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Log.text = "No Rooms to Join, creating one...";
        if(PhotonNetwork.CreateRoom(null, new Photon.Realtime.RoomOptions() { MaxPlayers = maxPlayersPerRoom }))
        {
            Log.text = "Room Created";
        } else
        {
            Log.text = "Fail Creating Room";
        }
    }
    public override void OnJoinedRoom()
    {
        Log.text = "Joinned";
        JoinRandomButton.interactable = false;
    }
    private void FixedUpdate()
    {
        if(PhotonNetwork.CurrentRoom != null)

            playersCount = PhotonNetwork.CurrentRoom.PlayerCount;
            PlayerCount.text = playersCount + "/" + maxPlayersPerRoom;
  
    }
}
