using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;


public class Manager : MonoBehaviourPunCallbacks
{
    void Awake()
    {
        Screen.SetResolution(1080, 1920, false);
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions{MaxPlayers = 6}, null);
    } 

    public override void OnJoinedRoom()
    {
        GameObject Pl = PhotonNetwork.Instantiate("Player", Vector2.zero, Quaternion.identity);
    }
}
