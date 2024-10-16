using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : ScriptableObject
{
    
    public new string name;
    public string description;

    public Material material; //In place of Artwork

    public int attack;
    public int defense;

}
