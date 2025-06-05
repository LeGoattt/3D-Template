using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [Header("Skill Stats")]
    public float PhysicalityStat; //Physical Damage. AKA. These hands
    public float AgilityStat; //Speed baby
    public float ArcaneStat; //Magic Damage
    public float ResistanceStat; //physical resistance
    public float MembraneStat; //Magical resistance 
    public float VitalityStat; //How much HP you have
    public float LuckStat; //lucky lucky

    [Header("Various Stats")]
    public float MaxOutput; //The max output of spells able to be used at your current level. Increases per player lvl
    public float PlayerLvL; //Yeah I wonder
    public float HP; //you know what it is
    public float EXP; //EXP it's kinda common knowledge in this day and age

    public float XPtoLvl; //How much XP you need to level up to the next lvl


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
