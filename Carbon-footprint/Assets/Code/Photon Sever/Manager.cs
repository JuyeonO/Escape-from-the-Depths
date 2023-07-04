using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun.UtilityScripts;


public class Manager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Awake()
    {
        Screen.SetResolution(1080, 1920, false);
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster() => PhotonNetwork.JoinOnCreateRoom("Room", new RoomOptions { MaxPlayer = 6 }, null);
    // Update is called once per frame
    void Update()
    {
        
    }
}
