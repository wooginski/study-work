using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class GameFunctions : MonoBehaviour
{
    public bool gameIsWon;
    public bool isEnemyAlive;
    public Transform playerObject;
    public Player boolbasaur;
    public Enemies enemies;
    public SceneManagement sceneManagement;
    public bool hasGainedXP;
    public int textState;
    public int expGained;
    public int battleText;

    // Start is called before the first frame update
    void Start()
    {
        boolbasaur = playerObject.GetComponent<Player>();
        enemies.GenerateEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        if (boolbasaur.health <=0)
        {
            sceneManagement.LossScreen();
        }
        switch (boolbasaur.level)
        {
            case 1:
                LevelOneBattle();
                if (enemies.enemyHealth <= 0)
                {
                    enemies.enemyHealth = 0;
                }
                if (boolbasaur.level >= 5)
                {
                    sceneManagement.EndScreen();
                }
                break;
            case 2:
                LevelTwoBattle();
                if (enemies.enemyHealth <= 0)
                {
                    enemies.enemyHealth = 0;
                }
                if (boolbasaur.level >= 5)
                {
                    sceneManagement.EndScreen();
                }
                break;
            case 3:
                LevelThreeBattle();
                if (enemies.enemyHealth <= 0)
                {
                    enemies.enemyHealth = 0;
                }
                if (boolbasaur.level >= 5)
                {
                    sceneManagement.EndScreen();
                }
                break;
            case 4:
                LevelThreeBattle();
                if (enemies.enemyHealth <= 0)
                {
                    enemies.enemyHealth = 0;
                }
                if (boolbasaur.level >= 5)
                {
                    sceneManagement.EndScreen();
                }
                break;
        }
    }
    public void LevelThreeBattle()
    {



        if (enemies.enemyHealth > 0)
        {
            switch (battleText)
            {
                case 0:
                    boolbasaur.battleText.text = "What will boolbasaur do";
                    battleText = battleText + 1;
                    break;

                case 1:

                    if (Input.GetKeyDown(KeyCode.A))
                    {
                        Tackle();
                        battleText = battleText + 1;
                    }
                    else if (Input.GetKeyDown(KeyCode.S))
                    {
                        VineWhip();
                        battleText = battleText + 1;
                    }
                    else if (Input.GetKeyDown(KeyCode.Z))
                    {
                        MagicalLeaf();
                        battleText = battleText + 1;
                    }
                    else if (Input.GetKeyDown(KeyCode.X))
                    {
                        Synthesis();
                        battleText = battleText + 1;
                    }
                    break;
                case 2:
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        if (enemies.enemyHealth <= 0)
                            battleText = 0;
                        else
                            EnemyAttack();
                        int dmg = enemies.damageDealt;
                        boolbasaur.health = boolbasaur.health - dmg;
                        Debug.Log(enemies.enemyName + " used tackle it did " + dmg + " damage!");
                        if (boolbasaur.health > 0)
                            Debug.Log("boolbasuar has " + boolbasaur.health + " HP remaining.");
                        else Debug.Log("boolbasaur has Fainted");
                        battleText = battleText + 1;
                    }
                    break;
                case 3:
                    if (Input.GetKeyDown(KeyCode.Space))
                        battleText = 0
                            ; break;

            }
        }
        else EnemyFaint();



    }
    public void LevelTwoBattle()
    {



        if (enemies.enemyHealth > 0)
        {
            switch (battleText)
            {
                case 0:
                    boolbasaur.battleText.text = "What will boolbasaur do";
                    battleText = battleText + 1;
                    break;

                case 1:

                    if (Input.GetKeyDown(KeyCode.A))
                    {
                        Tackle();
                        battleText = battleText + 1;
                    }
                    else if (Input.GetKeyDown(KeyCode.S))
                    {
                        VineWhip();
                        battleText = battleText + 1;
                    }
                    else if (Input.GetKeyDown(KeyCode.Z))
                    {
                        MagicalLeaf();
                        battleText = battleText + 1;
                    }
                    break;
                case 2:
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        if (enemies.enemyHealth <= 0)
                            battleText = 0;
                        else
                            EnemyAttack();
                        int dmg = enemies.damageDealt;
                        boolbasaur.health = boolbasaur.health - dmg;
                        Debug.Log(enemies.enemyName + " used tackle it did " + dmg + " damage!");
                        if (boolbasaur.health > 0)
                            Debug.Log("boolbasuar has " + boolbasaur.health + " HP remaining.");
                        else Debug.Log("boolbasaur has Fainted");
                        battleText = battleText + 1;
                    }
                    break;
                case 3:
                    if (Input.GetKeyDown(KeyCode.Space))
                        battleText = 0
                            ; break;

            }
        }
        else EnemyFaint();



    }
    public void LevelOneBattle()
    {



        if (enemies.enemyHealth > 0)
        {
            switch (battleText)
            {
                case 0:
                    boolbasaur.battleText.text = "What will boolbasaur do";
                    battleText = battleText + 1;
                    break;

                case 1:

                    if (Input.GetKeyDown(KeyCode.A))
                    {
                        Tackle();
                        battleText = battleText + 1;
                    }
                    else if (Input.GetKeyDown(KeyCode.S))
                    {
                        VineWhip();
                        battleText = battleText + 1;
                    }
                    break;
                case 2:
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        if (enemies.enemyHealth <= 0)
                            battleText = 0;
                        else
                            EnemyAttack();
                        int dmg = enemies.damageDealt;
                        boolbasaur.health = boolbasaur.health - dmg;
                        Debug.Log(enemies.enemyName+" used tackle it did " + dmg + " damage!");
                        if (boolbasaur.health > 0)
                            Debug.Log("boolbasuar has " + boolbasaur.health + " HP remaining.");
                        else Debug.Log("boolbasaur has Fainted");
                        battleText = battleText + 1;
                    }
                    break;
                case 3:
                    if (Input.GetKeyDown(KeyCode.Space))
                        battleText = 0
                            ; break;

            }
        }
        else EnemyFaint();



    }
    public void GameWin()
    {
        sceneManagement.EndScreen();
        Debug.Log("Congratulations your boolbasaur evolved into structasaur");
    }
    public void EnemyFaint()
    {
        switch (textState)
        {
            case 0:
                boolbasaur.battleText.text = "the wild " + enemies.enemyName + " has fainted. [SPACE]";
                textState = textState + 1;

                break;
            case 1:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    expGained = UnityEngine.Random.Range(enemies.enemyMaxHP, ((enemies.enemyMaxHP) * 2));
                    boolbasaur.exp = boolbasaur.exp + expGained;
                    Debug.Log("Boolbasaur gained " + expGained + " Exp.");
                }
                if (Input.GetKeyUp(KeyCode.Space))
                {
                    textState = textState + 1;
                }

                break;


            case 2:
                boolbasaur.battleText.text = "boolbasaur gained " + expGained + " exp. [SPACE]";
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (boolbasaur.exp >= boolbasaur.expThreshold)
                    {
                        Debug.Log("Boolbasaur has reached the exp threshold press [SPACE] to level up");
                    }
                    textState = textState + 1;

                }
                break;

            case 3:
                if (boolbasaur.exp >= boolbasaur.expThreshold)
                {
                    boolbasaur.battleText.text = "Boolbasaur has reached the exp threshold press [SPACE] to level up";

                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        textState = textState + 1;
                    }
                }
                else
                {
                    enemies.GenerateEnemy();
                    textState = 0;
                }
                break;
            case 4:
                boolbasaur.LevelUP();
                boolbasaur.battleText.text = "Boolbasaur has reached level " + (boolbasaur.level + 1) + "[SPACE]";
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    textState = textState + 1;
                }
                break;
            case 5:
                if (boolbasaur.level == 2)
                {
                    boolbasaur.battleText.text = "boolbasaur learned magical leaf [SPACE]";
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        Debug.Log("boolbasaur learned magical leaf");
                        boolbasaur.magicalLeafText.text = "Magical Leaf [Z]";
                        if (boolbasaur.exp >= boolbasaur.expThreshold) textState = textState - 2;
                        else
                            textState = textState + 1;
                    }
                }
                else if (boolbasaur.level == 3)
                {
                    boolbasaur.battleText.text = "boolbasaur learned synthesis [SPACE]";
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        Debug.Log("boolbasaur learned synthesis");
                        boolbasaur.synthesisText.text = "Synthesis [Z]";
                        if (boolbasaur.exp >= boolbasaur.expThreshold) textState = textState - 2;
                        else
                            textState = textState + 1;
                    }
                }
                else textState = textState + 1;
                break;
            case 6:
                enemies.GenerateEnemy();
                textState = 0;

                break;

        }

    }
    public void Tackle()
    {
        int damage = boolbasaur.Tackle();
        enemies.enemyHealth = enemies.enemyHealth - damage;
        Debug.Log("boolbasaur used tackle it did " + damage + " damage!");
        if (enemies.enemyHealth > 0)
            Debug.Log(enemies.enemyName + "has " + enemies.enemyHealth + " HP remaining.");
        else Debug.Log(enemies.enemyName + "has Fainted");
    }
    public void VineWhip()
    {        
        int damage = boolbasaur.VineWhip();
        if ((enemies.enemyType == "Bug") || (enemies.enemyTypeTwo == "flying"))
        {
            enemies.enemyHealth = enemies.enemyHealth - (damage / 2);
            boolbasaur.battleText.text = "Boolbasaur used Vine Whip, it did " + (damage/2) + " damage [SPACE]";
            Debug.Log("boolbasaur used Vine Whip it did " + (damage/2) + " damage, its not very effective");
        }
        else
        {
            enemies.enemyHealth = enemies.enemyHealth - damage;
            boolbasaur.battleText.text = "Boolbasaur used Vine Whip, it did " + damage + " damage [SPACE]";
            Debug.Log("boolbasaur used Vine Whip it did " + damage + " damage!");
        }
        if (enemies.enemyHealth > 0)
            Debug.Log(enemies.enemyName + "has " + enemies.enemyHealth + " HP remaining.");
        else Debug.Log(enemies.enemyName + "has Fainted");
    }
    public void MagicalLeaf()
    {

        int damage = boolbasaur.MagicalLeaf();
        if ((enemies.enemyType == "Bug") || (enemies.enemyTypeTwo == "flying"))
        {
            enemies.enemyHealth = enemies.enemyHealth - (damage / 2);
            boolbasaur.battleText.text = "Boolbasaur used Magical Leaf, it did " + (damage / 2) + " damage [SPACE]";
            Debug.Log("boolbasaur used Magical leaf it did " + (damage/2) + " damage, its not very effective");
        }
        else
        {
            enemies.enemyHealth = enemies.enemyHealth - damage;
            boolbasaur.battleText.text = "Boolbasaur used Magical Leaf, it did " + damage  + " damage [SPACE]";
            Debug.Log("boolbasaur used Magical Leaf it did " + damage + " damage!");
        }
        if (enemies.enemyHealth > 0)
            Debug.Log(enemies.enemyName + "has " + enemies.enemyHealth + " HP remaining.");
        else Debug.Log(enemies.enemyName + "has Fainted");
    }
    public void Synthesis()
    {
        int healing = boolbasaur.Synthesis();
        boolbasaur.health = boolbasaur.health + healing;
        if (boolbasaur.health > boolbasaur.maxHealth)
        {
            boolbasaur.health = boolbasaur.maxHealth;
        }
        Debug.Log("boolbasaur used Synthesis, it healed for " + healing + " HP");
    }



    public int EnemyAttack()
    {
        switch (enemies.enemyID)
        {

            case 1:
                enemies.attackUsed = UnityEngine.Random.Range(1, enemies.enemyLevel);
                if (enemies.attackUsed >= 3)
                    enemies.Tackle();
                else
                    enemies.BoolByte();
                break;
            case 2:
                enemies.Tackle();
                break;
            case 3:
                enemies.attackUsed = UnityEngine.Random.Range(1, enemies.enemyLevel);
                if (enemies.attackUsed >= 3)
                    enemies.Tackle();
                else
                    enemies.BoolByte();
                break;
            case 4:
                enemies.Tackle();
                break;
            case 5:
                enemies.attackUsed = UnityEngine.Random.Range(1, 3);
                if (enemies.attackUsed >= 3)
                    enemies.Tackle();
                else
                    enemies.Gustring();
                break;
            case 6:
                enemies.TackleSTAB();
                break;
            case 7:
                enemies.attackUsed = UnityEngine.Random.Range(1, enemies.enemyLevel);
                if (enemies.attackUsed >= 3)
                    enemies.Tackle();
                else
                    enemies.Peck();
                break;
            case 8:
                enemies.attackUsed = UnityEngine.Random.Range(1, enemies.enemyLevel);
                if (enemies.attackUsed >= 3)
                    enemies.Tackle();
                else
                    enemies.Thunderbool();
                break;
               
        }
        return enemies.damageDealt;
    }
}
