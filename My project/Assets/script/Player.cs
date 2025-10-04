using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI boolbasaur;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI experienceText;
    public TextMeshProUGUI battleText;
    public string myBugemon = "Bool-basaur";
    public int level = 0;
    public int atk = 0;
    public int exp = 0;
    public int expThreshold = 0;

    
    
    public void GameStartStatStuff()
    {
        atk = 8;
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
            Debug.Log(myName + " has " + currentExp + " exp.");
            Debug.Log((nextThreshold - currentExp) + " exp needed to level up.");
        }
    }
    public void LevelUP()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            level = level + 1;
            atk = (int)(atk * 1.25f);
            expThreshold = (level + 1) * (level + 1) * (level + 1);
            Debug.Log("level up, level is " + level);
            Debug.Log("attack is " + atk);
            Debug.Log("next exp threshold is "+  expThreshold);

        }
    }
   

    public int Tackle ()
    {
        battleText.text = "boolbasaur used tackle, it did " + (int)(atk * 0.45f) + " damage";
        return (int)(atk*0.45f);    
    }
    
    public int VineWhip ()
    {
        battleText.text = "boolbasaur used Vine Whip, it did " + (int)(atk * 0.55f) + " damage";
        return(int)(atk*0.45f);
    }
}
    
