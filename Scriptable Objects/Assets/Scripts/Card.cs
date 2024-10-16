using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public new string name;
    public string type;
    public string description;

    public Sprite artwork;
    public Sprite cardColorSprite;

    public int manaCost;
    public int attack;
    public int defense;

}
