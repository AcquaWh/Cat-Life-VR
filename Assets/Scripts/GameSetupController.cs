using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Photon.Pun;

public class GameSetupController : MonoBehaviour
{
    [SerializeField]
    Transform camtransform;
    void Start()
    {
        createPlayer();
    }

    void createPlayer()
    {
        PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Player"), Vector3.zero, Quaternion.identity);
    }
}
