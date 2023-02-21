using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingDown : MonoBehaviour
{
    private bool curPlace;
    private placeBuild curBuildPlace;

    private float placeUpdate = 0.05f;
    private float updateTime;
    private Vector3 placementPos;

    public GameObject itemPos;
    public static buildingDown inst;

    void Awake()
    {
        inst = this;
    }

    public void StartPlacing(placeBuild placeBuild)
    {
        curPlace = true;
        curBuildPlace = placeBuild;
        itemPos.SetActive(true);
    }

    public void CancelPlacing()
    {
        itemPos.SetActive(false);
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

        if (Time.time - updateTime > placeUpdate && curPlace)
        {
            updateTime = Time.time;

            placementPos = tileSelect.inst.TilePos();
            itemPos.transform.position = placementPos;
        }

        if(curPlace && Input.GetMouseButtonDown(0))
        {
            PlaceingTime();
        }

    }

}
