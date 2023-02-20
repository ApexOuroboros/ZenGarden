using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gManage : MonoBehaviour
{
    private List<placeBuild> objects = new List<placeBuild>();

    public static gManage inst;

    void Awake()
    {
        inst = this;
    }

    public void OnPlaceObject(placeBuild pObj)
    {
        objects.Add(pObj);
    }

    public void EndGame()
    {
        SceneManager.LoadScene(0);
    }

}
