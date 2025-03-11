/*
This script has functionality for leveling up
Holds base values for current level before modifiers, gear bonuses, etc.
*/

using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Scriptable Objects/Character")]
public class Character : ScriptableObject
{
    public string Name;
    public CharacterStats Stats;

    private int level;
    private float levelHP;
    private float levelATK;
    private float levelSP;
    private float levelARM;
    private float levelPLAT;

    public int Level{
        get { return level; }
    }

    public float BaseHealth
    {
        get { return levelHP; }
    }

    public float BaseAttack
    {
        get { return levelATK; }
    }

    public float BaseSpecialPoint
    {
        get { return levelSP; }
    }

    public float BaseArmor
    {
        get { return levelARM; }
    }

    public float BasePlating
    {
        get { return levelPLAT; }
    }

    public void SetLevel(int _level)
    {
        level = _level;
        levelHP = Calculator.GetStatLevel(Stats.BaseHP, Stats.BaseHPGrowth, Level);
        levelATK = Calculator.GetStatLevel(Stats.BaseATK, Stats.BaseATKGrowth, Level);
        levelSP = Calculator.GetStatLevel(Stats.BaseSP, Stats.BaseSPGrowth, Level);
        levelARM = Calculator.GetStatLevel(Stats.BaseARM, Stats.BaseARMGrowth, Level);
        levelPLAT = Calculator.GetStatLevel(Stats.BasePLAT, Stats.BasePLATGrowth, Level);
    }

    public override string ToString()
    {
        string result = "";
        result += "Name: " + Name;
        result += "\nLevel: " + Level;
        result += "\nStats";
        result += "\nBase Health: " + BaseHealth;
        result += "\nBase Attack: " + BaseAttack;
        result += "\nBase Special Points: " + BaseSpecialPoint;
        result += "\nBase Armor: " + BaseArmor;
        result += "\nBase Plating: " + BasePlating;
        return result;
    }
}
