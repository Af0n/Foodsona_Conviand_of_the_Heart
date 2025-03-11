using UnityEngine;

[CreateAssetMenu(fileName = "CharacterStats", menuName = "Scriptable Objects/CharacterStats")]
public class CharacterStats : ScriptableObject
{
    [Tooltip("Base amount of Health before levels and modifiers")]
    public float BaseHP;
    [Tooltip("Percentage of baseHP gained with each level")]
    public float BaseHPGrowth;
    [Header("Offensive Stats")]
    [Tooltip("Base amount of Attack before levels and modifiers")]
    public float BaseATK;
    [Tooltip("Percentage of baseATK gained with each level")]
    public float BaseATKGrowth;
    [Tooltip("Base amount of Special Points before levels and modifiers")]
    public float BaseSP;
    [Tooltip("Percentage of baseSP gained with each level")]
    public float BaseSPGrowth;
    [Header("Defensive Stats")]
    [Tooltip("Base amount of Armor before levels and modifiers")]
    public float BaseARM;
    [Tooltip("Percentage of baseARM gained with each level")]
    public float BaseARMGrowth;
    [Tooltip("Base amount of Plating before levels and modifiers")]
    public float BasePLAT;
    [Tooltip("Percentage of basePLAT gained with each level")]
    public float BasePLATGrowth;

    public override string ToString()
    {
        string result = "";
        result += "Base Health: " + BaseHP;
        result += "\nHealth Growth" + BaseHPGrowth * 100 + "%";
        result += "Base Attack: " + BaseATK;
        result += "\nAttack Growth" + BaseATKGrowth * 100 + "%";
        result += "Base Special Points: " + BaseSP;
        result += "\nSpecial Point Growth" + BaseSPGrowth * 100 + "%";
        result += "Base Armor: " + BaseARM;
        result += "\nArmor Growth" + BaseARMGrowth * 100 + "%";
        result += "Base Plating: " + BasePLAT;
        result += "\nPlating Growth" + BasePLATGrowth * 100 + "%";
        return result;
    }
}
