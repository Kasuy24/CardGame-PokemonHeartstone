using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Targets
{
    NONE,
    ALL_CREATURES,
    ENEMY_CREATURES,
    FRIENDLY_CREATURES,
    ENEMY_HERO,
    FRIENDLY_HERO,
    ALL_CHARACTERS,
    ENEMY_CHARACTERS,
    FRIENDLY_CHARACTER,
}


//Added CreateAssetMenu functionality
[CreateAssetMenu(fileName = "New Card", menuName = "Card")]

public class Card : ScriptableObject, IComparable<Card>
{ 
    [Header("Standard Info")]

//Clase Carta
    public string cardName;
    public string description;
    public Sprite art;
    public int manaCost;
    public Targets targets;

    [Header("Creature Info")]
    public int attack;
    public int health;
    public int maxHealth;
    public bool charge;
    public bool taunt; //despres podra ser un int amb els estats dormit, paralitzat, enverinat...
    public int numberOfAttacks = 1;
    public bool isCreautre;


    public int CompareTo(Card other)
    {
        //Comparem el nom de les cartes perque s'ordenin alfabeticament
        return this.cardName.CompareTo(other.cardName);
    }
}


