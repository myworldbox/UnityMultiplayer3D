using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class Dashboard : MonoBehaviourPunCallbacks
{
    public InputField nameInput;
    public InputField roomInput;

    public static string name;
    public static string room;

    public void StartGame()
    {
        if (nameInput.text != null && roomInput.text != null) {

            name = nameInput.text;
            room = roomInput.text;
            SceneManager.LoadScene("Pending");

            PhotonNetwork.ConnectUsingSettings();
        }
    }
}
