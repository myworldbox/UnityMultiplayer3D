using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviourPunCallbacks
{
    public GameObject playerPrefab;

    public void Start()
    {
        PhotonNetwork.Instantiate(playerPrefab.name, new Vector3(Random.Range(10, 20), Random.Range(100, 110), Random.Range(-200, -210)), Quaternion.identity, 0);
        // PhotonNetwork.Instantiate(playerPrefab.name, new Vector3(Random.Range(1, 10), Random.Range(1, 10), Random.Range(1, 10)), Quaternion.identity, 0);
    }
}
