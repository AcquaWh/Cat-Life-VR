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
    public byte maxPlayersPerRoom = 4;

    public void Connect()
    {
        if (!PhotonNetwork.IsConnected)
        {
            if (PhotonNetwork.ConnectUsingSettings())
            {
                Log.text += "\nConnected to Server";
            } else
            {
                Log.text += "\nFailing Connecting to Server";
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
        if (PhotonNetwork.JoinRandomRoom())
        {
            Log.text += "\nJoinned Room";
        } else
        {
            Log.text += "\nFail Joining";
        }
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Log.text += "\nNo Rooms to Join, creating one...";
        if(PhotonNetwork.CreateRoom(null, new Photon.Realtime.RoomOptions() { MaxPlayers = maxPlayersPerRoom }))
        {
            Log.text += "\nRoom Created";
        } else
        {
            Log.text += "\nFail Creating Room";
        }
    }
}
