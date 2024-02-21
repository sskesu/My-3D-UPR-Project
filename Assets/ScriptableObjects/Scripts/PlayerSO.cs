using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Characters/Player")]
public class PlayerSO : ScriptableObject
{
    [field : SerializeField] public PlayerGroundData GroundedData {  get; set; }
    [field : SerializeField] public PlayerAirData AirData { get; set; }
    [field : SerializeField] public PlayerAttackData AttackData { get; set; }
}
