using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Stats
{
    [Header("Skill Stats")]
    public float PhysicalityStat = 0; //Physical Damage. AKA. These hands
    public float AgilityStat = 0; //Speed baby
    public float ArcaneStat = 0; //Magic Damage
    public float ResistanceStat = 0; //physical resistance
    public float MembraneStat = 0; //Magical resistance 
    public float VitalityStat = 0; //How much HP you have
    public float LuckStat = 0; //lucky lucky

    [Header("Various Stats")]
    public float MaxOutput = 10; //The max output of spells able to be used at your current level. Increases per player lvl
    public float PlayerLvL = 0; //Yeah I wonder
    public float HP = 100; //you know what it is
    public float EXP = 0; //EXP it's kinda common knowledge in this day and age

    public float XPtoLvl = 500; //How much XP you need to level up to the next lvl
}
