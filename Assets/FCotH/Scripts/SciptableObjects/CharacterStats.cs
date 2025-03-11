using UnityEngine;

[CreateAssetMenu(fileName = "CharacterStats", menuName = "Scriptable Objects/CharacterStats")]
public class CharacterStats : ScriptableObject
{
    [Tooltip("Base amount of Health before levels and modifiers")]
    public float baseHP;
    [Header("Offensive Stats")]
    [Tooltip("Base amount of Attack before levels and modifiers")]
    public float baseATK;
    [Tooltip("Base amount of Special Points before levels and modifiers")]
    public float baseSP;
    [Header("Defensive Stats")]
    [Tooltip("Base amount of Armor before levels and modifiers")]
    public float baseARM;
    [Tooltip("Base amount of Plating before levels and modifiers")]
    public float basePLAT;
}
