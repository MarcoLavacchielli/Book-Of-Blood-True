using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Vigor Card", menuName = "Vigor Card")]
public class VigorCards : ScriptableObject
{
    public new string name;
    public string description;
    public Sprite image;
    public int vigorcost;
}
