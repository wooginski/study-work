using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI boolbasaur;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI experienceText;
    public TextMeshProUGUI battleText;
    public TextMeshProUGUI magicalLeafText;
    public TextMeshProUGUI synthesisText;
    public TextMeshProUGUI healthStatSummary;
    public TextMeshProUGUI healthStatsText;
    public Enemies enemy;
    public string myBugemon = "Bool-basaur";
    public int level = 0;
    public int atk = 0;
    public int spa = 0;
    public int def = 0;
    public int spd = 0;
    public int exp = 0;
    public int expThreshold = 0;
    public string type;
    public int health;
    public int maxHealth;
    
    
    public void GameStartStatStuff()
    {
        type = "Grass";
        maxHealth = 20;
        health = maxHealth;
        atk = 8;
        spa = 11;
        def = 8;
        spd = 11;
        level = 1;
        exp = 0;
        expThreshold = (level + 1) * (level + 1) * (level + 1);
        BugemonLvlUpInfo(myBugemon, level, atk, exp, expThreshold);
    }

    // Start is called before the first frame update
    void Start()
    {
        GameStartStatStuff();
      
    }

    // Update is called once per frame
    void Update()
    {
        experienceText.text = exp + "/" + expThreshold + "exp.";
        expThreshold = (level + 1) * (level + 1) * (level + 1);
        levelText.text = "Lvl " + level;
        healthStatSummary.text = health + "/" + maxHealth + "HP";
        healthStatsText.text = health + "/" + maxHealth + "HP";
    }

    public void BugemonLvlUpInfo(string myName, int myLevel, int myAtk, int currentExp, int nextThreshold)
    {
        if (level == 1)
        {
            Debug.Log(myName + " is level " + myLevel + ".");
            boolbasaur.text = myName;
            levelText.text = "Lvl " + myLevel;
            experienceText.text = currentExp + "/" + nextThreshold + " Exp.";
            Debug.Log("Attack is " + myAtk + ".");
            Debug.Log("special attack is " + spa);
            Debug.Log("defence is " + def);
            Debug.Log("special defence is " + spd);
            Debug.Log("HP is " + maxHealth);
            Debug.Log(myName + " has " + currentExp + " exp.");
            Debug.Log((nextThreshold - currentExp) + " exp needed to level up.");
        }
    }
    public void LevelUP()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (level < 4)
            {
                level = level + 1;
                maxHealth = (int)(maxHealth * 1.25f);
                health = maxHealth;
                atk = (int)(atk * 1.25f);
                spa = (int)(spa * 1.25f);
                def = (int)(def * 1.25f);
                spd = (int)(spd * 1.25f);
                expThreshold = (level + 1) * (level + 1) * (level + 1);
                Debug.Log("level up, level is " + level);
                Debug.Log("HP is " + maxHealth);
                Debug.Log("attack is " + atk);
                Debug.Log("special attack is " + spa);
                Debug.Log("defence is " + def);
                Debug.Log("special defence is " + spd);
                Debug.Log("next exp threshold is " + expThreshold);
              
            }
            else
            {
                Debug.Log("level up, level is " + level);
                level = level + 1;
                atk = (int)(atk * 1.25f);
                expThreshold = (level + 1) * (level + 1) * (level + 1);
            }
        }
    }

    public int Tackle()
    {
        battleText.text = "Boolbasaur used tackle, it did " + (int)(((((((2 * enemy.enemyLevel) / 5) + 2) * 40 * (atk / enemy.enemyDef)) / 50) + 2) * Random.Range(0.85f, 1f)) + " damage [SPACE]";
        return (int)(((((((2 * level) / 5) + 2) * 40 * (atk / enemy.enemyDef)) / 50) + 2) * Random.Range(0.85f, 1f));

    }


    public int VineWhip ()
    {
       
        return (int)(((((((2 * level) / 5) + 2) * 45 * (atk / enemy.enemyDef)) / 50) + 2)*1.5 * Random.Range(0.85f, 1f));
    }
    public int MagicalLeaf()
    {
        
        return (int)(((((((2 * level) / 5) + 2) * 60 * (spa / enemy.enemySpD)) / 50) + 2) * 1.5 * Random.Range(0.85f, 1f));
    }
    public int Synthesis()
    {
        battleText.text = "boolbasaur used Synthesis, it healed for " + (int)(maxHealth * 0.5) + " HP";
        return (int)(maxHealth * 0.5);
    }

}
    
