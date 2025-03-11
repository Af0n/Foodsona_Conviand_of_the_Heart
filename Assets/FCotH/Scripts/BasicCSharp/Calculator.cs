/*
This script is a general purpose script for calculations
*/

public static class Calculator
{
    // returns the stat after level growth calculation
    public static float GetStatLevel(float baseStat, float growth, int level){
        return baseStat * (1 + growth * (level - 1));
    }
}
