//****************************************************************************
// Description:
// Author: hiramtan@live.com
//****************************************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private RootSystems s;
    // Use this for initialization
    void Start()
    {
        s = new RootSystems(Contexts.sharedInstance);
        s.Initialize();
    }
    // Update is called once per frame
    void Update()
    {
        s.Execute();
    }
}
