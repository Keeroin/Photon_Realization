using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Managers/GameSettings")]
public class GameSettings : ScriptableObject
{
    [SerializeField] private string _gameVersion = "0.0.0";
    public string GameVersion { get => _gameVersion; }

    [SerializeField] private string _nickName = "Keeroin";
    public string NickName { get => _nickName + Random.Range(0, 9999).ToString(); }
}
