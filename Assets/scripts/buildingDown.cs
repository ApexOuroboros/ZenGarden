using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingDown : MonoBehaviour
{
    private bool curPlace;
    private placeBuild curBuildPlace;

    private Vector3 placementPos;

    public static buildingDown inst;

    void Awake()
    {
        inst = this;
    }

    public void StartPlacing(placeBuild placeBuild)
    {
        curPlace = true;
        curBuildPlace = placeBuild;
    }

    public void CancelPlacing()
    {
        curPlace = false;
    }

    void PlaceingTime()
    {
        GameObject gameObject = Instantiate(curBuildPlace.prefab, placementPos, Quaternion.identity);
        gManage.inst.OnPlaceObject(curBuildPlace);

        CancelPlacing();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CancelPlacing();
        }

        if(curPlace && Input.GetMouseButtonDown(0))
        {
            PlaceingTime();
        }

    }

}
