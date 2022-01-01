using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
public class NetworkManager : MonoBehaviourPunCallbacks
{
    private void Start() {
        ConnectToServer();
    }
    void ConnectToServer(){
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("try to connect to the server");
    }

    public override void OnConnectedToMaster() {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 2;
        roomOptions.IsVisible = true;
        roomOptions.IsOpen = true;


        base.OnConnectedToMaster();
        Debug.Log("Connected to server");

        PhotonNetwork.JoinOrCreateRoom("room1", roomOptions, TypedLobby.Default);
    }

    public override void OnJoinedRoom(){
        Debug.Log("room joined");
        base.OnJoinedRoom();
    }
    public override void OnPlayerEnteredRoom(Player newPlayer){
        Debug.Log("A new player has joined the room");
        base.OnPlayerEnteredRoom(newPlayer);
    }
}
