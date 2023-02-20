using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingDown : MonoBehaviour
{
    private bool curPlace;
    private placeBuild curBuildPlace;

    public static buildingDown inst;

    void Awake()
    {
        inst = this;
    }
}
