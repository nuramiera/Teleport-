using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System;
using UnityEngine.SceneManagement;


public class Manager : MonoBehaviourPunCallbacks
{      
    #region Public Fields

    [Tooltip("The prefab to use for representing the player")]
    public  GameObject playerPrefab;
    public Transform spawnPoint;
   
    #endregion

    #region Public Methods

    // Start is called before the first frame update
    void Start()
    {
        if (PhotonNetwork.CurrentRoom == null)
        {
            Debug.Log("return to lobby");
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
            return;
        }
           
        PhotonNetwork.Instantiate(this.playerPrefab.name, spawnPoint.position, Quaternion.identity, 0);    
        
    }

    public void LeaveRoom()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
    }

    #endregion
}
