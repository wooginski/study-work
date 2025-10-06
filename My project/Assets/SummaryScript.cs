using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SummaryScript : MonoBehaviour
{
    public Player boolbasaur;
    public TextMeshProUGUI level;
    public TextMeshProUGUI atk;
    public TextMeshProUGUI spA;
    public TextMeshProUGUI def;
    public TextMeshProUGUI spD;
    public TextMeshProUGUI exp;
    public TextMeshProUGUI tackle;
    public TextMeshProUGUI vineWhip;
    public TextMeshProUGUI magicalLeaf;
    public TextMeshProUGUI synthesis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        level.text = "Lvl "+ boolbasaur.level;
        atk.text = boolbasaur.atk + " Atk";
        spA.text = boolbasaur.spa + " SpA";
        def.text = boolbasaur.def + " Def";
        spD.text = boolbasaur.spd + " SpD";
        exp.text = boolbasaur.exp + "/" + boolbasaur.expThreshold;
        tackle.text = "Tackle [Normal] [P]  Pwr 40  Acc 100";
        vineWhip.text = "Vinewhip [Grass] [P]  Pwr 45  Acc 100";
        if (boolbasaur.level >= 2)
        magicalLeaf.text = "Magical leaf [Grass] [Sp]  Pwr 60  Acc --";
        if (boolbasaur.level >= 3)
        synthesis.text = "Synthesis [Grass] [S]  Pwr --  Acc --";

    }
}
