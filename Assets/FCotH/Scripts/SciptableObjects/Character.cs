using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Scriptable Objects/Character")]
public class Character : ScriptableObject
{
    public string Name;
    public int Level;
    public CharacterStats Stats;

    public override string ToString()
    {
        string result = "";
        result += "Name: " + Name;
        result += "\nLevel: " + Level;
        result += "\nStats";
        result += "\nHP: " + LevelCalculator.GetStatLevel(Stats.BaseHP, Stats.BaseHPGrowth, Level);
        result += "\nATK: " + LevelCalculator.GetStatLevel(Stats.BaseATK, Stats.BaseATKGrowth, Level);
        result += "\nSP: " + LevelCalculator.GetStatLevel(Stats.BaseSP, Stats.BaseSPGrowth, Level);
        result += "\nARM: " + LevelCalculator.GetStatLevel(Stats.BaseARM, Stats.BaseARMGrowth, Level);
        result += "\nPLAT: " + LevelCalculator.GetStatLevel(Stats.BasePLAT, Stats.BasePLATGrowth, Level);
        return base.ToString();
    }
}
