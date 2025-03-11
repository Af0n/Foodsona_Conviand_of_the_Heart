/*
This script is for use with combat.
holds current values for HP and SP
*/

using UnityEngine;

public class CombatCharacter : MonoBehaviour
{
    public Character Char;
    private float currentHP;
    private float currentSP;

    public float Health{
        get { return currentHP; }
    }

    public float SpecialPoints{
        get { return currentSP; }
    }
}
