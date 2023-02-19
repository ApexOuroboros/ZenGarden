using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "Tree Objects", menuName = "New Tree Objects")]

public class placeBuild : ScriptableObject
{
    public string itemName;
    public GameObject prefab;
}
