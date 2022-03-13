using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class CreateAndJoin : MonoBehaviourPunCallbacks
{
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom(Dashboard.room, null, null, null);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("DemoScene");
        // PhotonNetwork.LoadLevel("Game");
    }
}
