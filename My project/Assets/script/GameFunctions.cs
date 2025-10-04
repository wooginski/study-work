using System.Collections;
using System.Collections.Generic;
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

    // Start is called before the first frame update
    void Start()
    {
        boolbasaur = playerObject.GetComponent<Player>();
        enemies.GenerateEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        Battle();
        if (enemies.enemyHealth <= 0)
        {
            enemies.enemyHealth = 0;
        }
        if (boolbasaur.level >= 5)
        {
            sceneManagement.EndScreen();
        }
    }

    public void Battle()
    {
        if (enemies.enemyHealth > 0)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                int damage = boolbasaur.Tackle();
                enemies.enemyHealth = enemies.enemyHealth - damage;
                Debug.Log("boolbasaur used tackle it did " + damage + " damage!");
                if (enemies.enemyHealth > 0)
                Debug.Log(enemies.wildMon + "has " + enemies.enemyHealth + " HP remaining.");
                else Debug.Log(enemies.wildMon + "has Fainted");
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                int damage = boolbasaur.VineWhip();
                enemies.enemyHealth = enemies.enemyHealth - damage;
                Debug.Log("boolbasaur used Vine Whip it did " + damage + " damage!");
                if (enemies.enemyHealth > 0)
                    Debug.Log(enemies.wildMon + "has " + enemies.enemyHealth + " HP remaining.");
                else Debug.Log(enemies.wildMon + "has Fainted");
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
                    boolbasaur.battleText.text = "the wild " + enemies.wildMon.text + " has fainted. [SPACE]";
                        textState = textState + 1;
                    
                    break;
                case 1:
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                    expGained = Random.Range(enemies.enemyMaxHP, ((enemies.enemyMaxHP) * 2));
                        boolbasaur.exp = boolbasaur.exp +  expGained;
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
                              textState = textState + 1;
                    }
                    break;

                case 3:
                    if (boolbasaur.exp >= boolbasaur.expThreshold)
                    {
                        boolbasaur.battleText.text = "Boolbasaur has reached the exp threshold press [SPACE] to level up";
                    Debug.Log("Boolbasaur has reached the exp threshold press [SPACE] to level up"); 
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
                boolbasaur.battleText.text = "Boolbasaur has reached level " + (boolbasaur.level+1)  + "[SPACE]";
                if (Input.GetKeyDown (KeyCode.Space))
                {
                   if(boolbasaur.exp >= boolbasaur.expThreshold) textState = textState - 1;
                   else textState = textState + 1;
                }
                break;
            case 5:
                        enemies.GenerateEnemy();
                    textState = 0;
                     
                        break; 
                       
            }                
            
        
    }

}
