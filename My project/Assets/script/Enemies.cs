
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public Player boolbasaur;
    public TextMeshProUGUI battleText;
    public TextMeshProUGUI wildMon;
    public TextMeshProUGUI wildMonHP;
    public TextMeshProUGUI wildMonLvl;
    public int enemyMaxHP = 0;
    public int enemyHealth = 0;
    public int enemyLevel = 0;
    public int enemyID = 0;
    public int enemyAtk = 0;
    public int enemySpA = 0;
    public int enemyDef = 0;
    public int enemySpD = 0;
    public string enemyName;
    public string enemyType;
    public string enemyTypeTwo;
    public int attackUsed;
    public string attackType;
    public int damageDealt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wildMonHP.text = enemyHealth + "/" + enemyMaxHP;
        wildMonLvl.text = "Lvl "+ enemyLevel;
    }

    public void GenerateEnemy()
    {
       enemyID = UnityEngine.Random.Range(1, 9);
        if (enemyID == 1)
        {
            Chartapie();
        }
        else if (enemyID == 2) 
        {
            Chartapod();
        }
        else if (enemyID == 3)
        {
            Voidle();
        } 
        else if (enemyID == 4)
        {
            Voidkuna();
        }
        else if (enemyID == 5)
        {
            Pidgint();
        }
        else if (enemyID == 6)
        {
            Nulltata();
        }
        else if (enemyID == 7)
        {
            Spearfloat();
        }
        else if (enemyID == 8)
        {
            Printkachu();
        }
    }

    public void Chartapie()
    {
        enemyLevel = UnityEngine.Random.Range(boolbasaur.level, boolbasaur.level+3);
        enemyType = "Bug";
        enemyAtk = 4 + (enemyLevel);
        enemyDef = 4 + (enemyLevel);
        enemySpA = 3 + (enemyLevel);
        enemySpD = 3 + (enemyLevel);
        enemyHealth = enemyLevel * 5 + 5;
        enemyMaxHP = enemyLevel * 5 + 5;
        battleText.text = "A wild Chartapie appeared:";
        enemyName = "Chartapie";
        wildMon.text = "Chartapie";
        Debug.Log("A wild " + enemyName + " has appeared! level " + enemyLevel + "with " + enemyHealth + " HP!");
    }

    public void Chartapod()
    {
        enemyLevel = UnityEngine.Random.Range(boolbasaur.level, boolbasaur.level + 3);
        enemyType = "Bug";
        enemyAtk = 3 + (enemyLevel);
        enemyDef = 8 + (enemyLevel);
        enemySpA = 4 + (enemyLevel);
        enemySpD = 4 + (enemyLevel);
        enemyHealth = enemyLevel * 5 + 5;
        enemyMaxHP = enemyLevel * 5 + 5;
        battleText.text = "A wild Chartapod appeared:";
        enemyName = "Chartapod";
        wildMon.text = "Chartapod";
        Debug.Log("A wild " + enemyName + " has appeared! level " + enemyLevel + "with " + enemyHealth + " HP!");
    }

    public void Voidle()
    {
        enemyLevel = UnityEngine.Random.Range(boolbasaur.level, boolbasaur.level + 3);
        enemyType = "Bug";
        enemyAtk = 4 + (enemyLevel);
        enemyDef = 4 + (enemyLevel);
        enemySpA = 3 + (enemyLevel);
        enemySpD = 3 + (enemyLevel);
        enemyHealth = enemyLevel * 5 + 5;
        enemyMaxHP = enemyLevel * 5 + 5;
        battleText.text = "A wild Voidle appeared:";
        enemyName = "Voidle";
        wildMon.text = "Voidle";
        Debug.Log("A wild " + enemyName + " has appeared! level " + enemyLevel + "with " + enemyHealth + " HP!");
    }

    public void Voidkuna()
    {
        enemyLevel = UnityEngine.Random.Range(boolbasaur.level, boolbasaur.level + 3);
        enemyType = "Bug";
        enemyAtk = 3 + (enemyLevel);
        enemyDef = 8 + (enemyLevel);
        enemySpA = 4 + (enemyLevel);
        enemySpD = 4 + (enemyLevel);
        enemyHealth = enemyLevel * 5 + 5;
        enemyMaxHP = enemyLevel * 5 + 5;
        battleText.text = "A wild Voidkuna appeared:";
        enemyName = "Voidkuna";
        wildMon.text = "Voidkuna";
        Debug.Log("A wild " + enemyName + " has appeared! level " + enemyLevel + "with " + enemyHealth + " HP!");
    }

    public void Pidgint()
    {
        enemyLevel = UnityEngine.Random.Range(boolbasaur.level, boolbasaur.level + 3);
        enemyType = "Normal";
        enemyAtk = 8 + (enemyLevel);
        enemyDef = 8 + (enemyLevel);
        enemySpA = 4 + (enemyLevel);
        enemySpD = 4 + (enemyLevel);
        enemyTypeTwo = "Flying";
        enemyHealth = enemyLevel * 5 + 5;
        enemyMaxHP = enemyLevel * 5 + 5;
        battleText.text = "A wild Pidgint appeared:";
        enemyName = "Pidgint";
        wildMon.text = "Pidgint";
        Debug.Log("A wild " + enemyName + " has appeared! level " + enemyLevel + "with " + enemyHealth + " HP!");
    }
    
    public void Nulltata()
    {
        enemyLevel = UnityEngine.Random.Range(boolbasaur.level, boolbasaur.level + 3);
        enemyType = "Normal";
        enemyAtk = 10 + (enemyLevel);
        enemyDef = 4 + (enemyLevel);
        enemySpA = 3 + (enemyLevel);
        enemySpD = 4 + (enemyLevel);
        enemyHealth = enemyLevel * 5 + 5;
        enemyMaxHP = enemyLevel * 5 + 5;
        battleText.text = "A wild Nulltata appeared:";
        enemyName = "Nulltata";
        wildMon.text = "Nulltata";
        Debug.Log("A wild " + enemyName + " has appeared! level " + enemyLevel + "with " + enemyHealth + " HP!");
    }

    public void Spearfloat()
    {
        enemyLevel = UnityEngine.Random.Range(boolbasaur.level, boolbasaur.level + 3);
        enemyType = "Normal";
        enemyTypeTwo = "Flying";
        enemyAtk = 10 + (enemyLevel);
        enemyDef = 4 + (enemyLevel);
        enemySpA = 4 + (enemyLevel);
        enemySpD = 4 + (enemyLevel);
        enemyHealth = enemyLevel * 5 + 5;
        enemyMaxHP = enemyLevel * 5 + 5;
        battleText.text = "A wild Spearfloat appeared:";
        enemyName = "Spearfloat";
        wildMon.text = "Spearfloat";
        Debug.Log("A wild " + enemyName + " has appeared! level " + enemyLevel + "with " + enemyHealth + " HP!");
    }

    public void Printkachu()
    {
        enemyLevel = UnityEngine.Random.Range(boolbasaur.level, boolbasaur.level + 3);
        enemyType = "Electric";
        enemyAtk = 10 + (enemyLevel);
        enemyDef = 4 + (enemyLevel);
        enemySpA = 10 + (enemyLevel);
        enemySpD = 4 + (enemyLevel);
        enemyHealth = enemyLevel * 5 + 5;
        enemyMaxHP = enemyLevel * 5 + 5;
        battleText.text = "A wild Printkachu appeared:";
        enemyName = "Printkachu";
        wildMon.text = "Printkachu";
        Debug.Log("A wild " + enemyName + " has appeared! level " + enemyLevel + "with " + enemyHealth + " HP!"); 
    }
    
    public int Tackle()
    {
        attackType = "Normal";
        battleText.text = enemyName + " used tackle, it did " + (int)(((((((2 * enemyLevel) / 5) + 2) * 40 * (enemyAtk / boolbasaur.def)) / 50) + 2) * Random.Range(0.85f, 1f)) + " damage [SPACE]";
        return damageDealt =(int)(((((((2 * enemyLevel) / 5) + 2) * 40 * (enemyAtk / boolbasaur.def)) / 50) + 2) * Random.Range(0.85f, 1f));
    }
    public int TackleSTAB()
    {
        attackType = "Normal";
        battleText.text = enemyName + " used tackle, it did " + (int)(((((((2 * enemyLevel) / 5) + 2) * 40 * (enemyAtk / boolbasaur.def)) / 50) + 2)*1.5 * Random.Range(0.85f, 1f)) + " damage [SPACE]";
        return damageDealt = (int)(((((((2 * enemyLevel) / 5) + 2) * 40 * (enemyAtk / boolbasaur.def)) / 50) + 2)*1.5 * Random.Range(0.85f, 1f));
    }
    public int BoolByte()
    {
        attackType = "Bug";
        battleText.text = enemyName + " used Char Bite, it did " + (int)((((((((2 * enemyLevel) / 5) + 2) * 60 * (enemyAtk / boolbasaur.def)) / 50) + 2) * 1.5 * 2) * Random.Range(0.85f, 1f)) + " damage, its super effective [SPACE]";
        return damageDealt = (int)((((((((2 * enemyLevel) / 5) + 2) * 60 * (enemyAtk / boolbasaur.def)) / 50) + 2) * 1.5 * 2) * Random.Range(0.85f, 1f));
    }
    public int Gustring()
    {
        battleText.text = enemyName + " used gust, it did " + (int)((((((((2 * enemyLevel) / 5) + 2) * 40 * (enemySpA / boolbasaur.spd)) / 50) + 2) * 1.5 * 2) * Random.Range(0.85f, 1f)) + " damage, it's super effective [SPACE]";
       return damageDealt = (int)((((((((2 * enemyLevel) / 5) + 2) * 40 * (enemySpA / boolbasaur.spd)) / 50) + 2) * 1.5 * 2) * Random.Range(0.85f, 1f));
    }
    public int Peck()
    {
        battleText.text = enemyName + " used peck, it did " + (int)((((((((2 * enemyLevel) / 5) + 2) * 35 * (enemyAtk / boolbasaur.def)) / 50) + 2) * 1.5 * 2) * Random.Range(0.85f, 1f)) + " damage, it's super effective [SPACE]";
        return damageDealt = (int)((((((((2 * enemyLevel) / 5) + 2) * 35 * (enemyAtk / boolbasaur.def)) / 50) + 2) * 1.5 * 2) * Random.Range(0.85f, 1f));
    }
    public int Thunderbool()
    {
        battleText.text = enemyName + " used thunderbool, it did " + (int)((((((((2 * enemyLevel) / 5) + 2) * 40 * (enemySpA / boolbasaur.spd)) / 50) + 2) * 1.5 * 0.5) * Random.Range(0.85f, 1f)) + " damage, its not very effective [SPACE]";
        return damageDealt =  (int)((((((((2 * enemyLevel) / 5) + 2) * 40 * (enemySpA / boolbasaur.spd)) / 50) + 2) * 1.5 * 0.5) * Random.Range(0.85f, 1f));
    }





}
