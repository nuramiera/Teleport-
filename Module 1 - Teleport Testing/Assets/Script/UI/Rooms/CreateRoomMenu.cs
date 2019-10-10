using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;
using Photon.Pun;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class CreateRoomMenu : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Text _RoomName;

    private RoomCanvases _roomCanvases;
    public SteamVR_LaserPointer laserPointer;

    void Awake()
    {
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Keyboard")
        {
            Debug.Log("Keyboard was clicked");
        }
        else if (e.target.name == "Button")
        {
            Debug.Log("Button was clicked : Create Room Menu");
            OnClick_CreateRoom();
        }
    }

    public void FirstInitialize(RoomCanvases canvases)
    {
        _roomCanvases = canvases;
    }

    public void OnClick_CreateRoom()
    {
        Debug.Log("Creating room ");

        if (PhotonNetwork.IsConnected)
        {
            //return;

            PhotonNetwork.CreateRoom(_RoomName.text, new RoomOptions { MaxPlayers = 4 }, null);
            Debug.Log("Create Room success");
           // _roomCanvases.CurrentRoomCanvas.Show();
        }


        /*RoomOptions options = new RoomOptions();
        options.MaxPlayers = 4;
        PhotonNetwork.JoinOrCreateRoom(_RoomName.text, options, TypedLobby.Default);*/

        

    }

    

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Creation room failed."  + message, this);
    }
}
