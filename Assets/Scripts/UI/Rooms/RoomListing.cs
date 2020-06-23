using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomListing : MonoBehaviour
{
    public RoomInfo RoomInfo { get; private set; }
    
    [SerializeField] private Text _text;

    public void SetRoomInfo(RoomInfo roomInfo)
    {
        RoomInfo = roomInfo;
        _text.text = $"{roomInfo.Name} [{roomInfo.MaxPlayers}]";
    }
}
