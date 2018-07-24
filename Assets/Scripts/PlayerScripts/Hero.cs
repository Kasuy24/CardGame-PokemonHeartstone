using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HeroClass
{
    Trainer,
    Professor
}

[CreateAssetMenu(fileName = "NewHero", menuName ="Players/Hero")]

public class Hero : ScriptableObject {

    public HeroClass heroClass;

    public string heroName;
    public Sprite avatar;
    public int health;
    public int attack;
    public int armor;

    public HeroPower power;
	
	
}
