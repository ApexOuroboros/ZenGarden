using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class tileSelect : MonoBehaviour
{
    private Camera cam;
    public static tileSelect inst;

    void Awake()
    {
        inst = this;
    }

    void Start()
    {
        cam = Camera.main;
    }

    public Vector3 TilePos()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return new Vector3(0, -99, 0);
        }

        Plane plane = new Plane(Vector3.up, Vector3.zero);
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        float rayout = 0.0f;

        if(plane.Raycast(cam.ScreenPointToRay(Input.mousePosition), out rayout))
        {
            Vector3 newPos = ray.GetPoint(rayout) - new Vector3(0.5f, 0.0f, 0.5f);
            return new Vector3(Mathf.CeilToInt(newPos.x), 0, Mathf.CeilToInt(newPos.z));
        }

        return new Vector3(0, -99, 0);

    }

}
