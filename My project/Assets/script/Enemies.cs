using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public TextMeshProUGUI battleText;
    public TextMeshProUGUI wildMon;
    public TextMeshProUGUI wildMonHP;
    public TextMeshProUGUI wildMonLvl;
    public int enemyMaxHP = 0;
    public int enemyHealth = 0;
    public int enemyLevel = 0;
    public int enemyID = 0;
    
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
       enemyID = Random.Range(1, 9);
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
        enemyLevel =Random.Range(1, 6);
        enemyHealth = enemyLevel * 5 + 5;
        enemyMaxHP = enemyLevel * 5 + 5;
        battleText.text = "A wild Chartapie appeared:";
        wildMon.text = "Chartapie";
        Debug.Log("A wild " + wildMon + " has appeared! level " + enemyLevel + "with " + enemyHealth + " HP!");
    }

    public void Chartapod()
    {
        enemyLevel = Random.Range(1, 6);
        enemyHealth = enemyLevel * 5 + 5;
        enemyMaxHP = enemyLevel * 5 + 5;
        battleText.text = "A wild Chartapod appeared:";
        wildMon.text = "Chartapod";
        Debug.Log("A wild " + wildMon + " has appeared! level " + enemyLevel + "with " + enemyHealth + " HP!");
    }

    public void Voidle()
    {
        enemyLevel = Random.Range(1, 6);
        enemyHealth = enemyLevel * 5 + 5;
        enemyMaxHP = enemyLevel * 5 + 5;
        battleText.text = "A wild Voidle appeared:";
        wildMon.text = "Voidle";
        Debug.Log("A wild " + wildMon + " has appeared! level " + enemyLevel + "with " + enemyHealth + " HP!");
    }

    public void Voidkuna()
    {
        enemyLevel = Random.Range(1, 6);
        enemyHealth = enemyLevel * 5 + 5;
        enemyMaxHP = enemyLevel * 5 + 5;
        battleText.text = "A wild Voidkuna appeared:";
        wildMon.text = "Voidkuna";
        Debug.Log("A wild " + wildMon + " has appeared! level " + enemyLevel + "with " + enemyHealth + " HP!");
    }

    public void Pidgint()
    {
        enemyLevel = Random.Range(1, 6);
        enemyHealth = enemyLevel * 5 + 5;
        enemyMaxHP = enemyLevel * 5 + 5;
        battleText.text = "A wild Pidgint appeared:";
        wildMon.text = "Pidgint";
        Debug.Log("A wild " + wildMon + " has appeared! level " + enemyLevel + "with " + enemyHealth + " HP!");
    }
    
    public void Nulltata()
    {
        enemyLevel = Random.Range(1, 6);
        enemyHealth = enemyLevel * 5 + 5;
        enemyMaxHP = enemyLevel * 5 + 5;
        battleText.text = "A wild Nulltata appeared:";
        wildMon.text = "Nulltata";
        Debug.Log("A wild " + wildMon + " has appeared! level " + enemyLevel + "with " + enemyHealth + " HP!");
    }

    public void Spearfloat()
    {
        enemyLevel = Random.Range(1, 6);
        enemyHealth = enemyLevel * 5 + 5;
        enemyMaxHP = enemyLevel * 5 + 5;
        battleText.text = "A wild Spearfloat appeared:";
        wildMon.text = "Spearfloat";
        Debug.Log("A wild " + wildMon + " has appeared! level " + enemyLevel + "with " + enemyHealth + " HP!");
    }

    public void Printkachu()
    {
        enemyLevel = Random.Range(1, 6);
        enemyHealth = enemyLevel * 5 + 5;
        enemyMaxHP = enemyLevel * 5 + 5;
        battleText.text = "A wild Printkachu appeared:";
        wildMon.text = "Printkachu";
        Debug.Log("A wild " + wildMon + " has appeared! level " + enemyLevel + "with " + enemyHealth + " HP!"); 
    }
}
