using UnityEngine;

[CreateAssetMenu(fileName = "CharacterStats", menuName = "Scriptable Objects/CharacterStats")]
public class CharacterStats : ScriptableObject
{
    [Tooltip("Base amount of Health before levels and modifiers")]
    public float baseHP;
    [Tooltip("Percentage of baseHP gained with each level")]
    public float baseHPGrowth;
    [Header("Offensive Stats")]
    [Tooltip("Base amount of Attack before levels and modifiers")]
    public float baseATK;
    [Tooltip("Percentage of baseATK gained with each level")]
    public float baseATKGrowth;
    [Tooltip("Base amount of Special Points before levels and modifiers")]
    public float baseSP;
    [Tooltip("Percentage of baseSP gained with each level")]
    public float baseSPGrowth;
    [Header("Defensive Stats")]
    [Tooltip("Base amount of Armor before levels and modifiers")]
    public float baseARM;
    [Tooltip("Percentage of baseARM gained with each level")]
    public float baseARMGrowth;
    [Tooltip("Base amount of Plating before levels and modifiers")]
    public float basePLAT;
    [Tooltip("Percentage of basePLAT gained with each level")]
    public float basePLATGrowth;
}
