/****************************************************************
 * Description: 
 * 
 * Author: hiramtan@live.com
 */ //////////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;
using Entitas;

public class LogMouseSystem : IExecuteSystem
{
    private Contexts _contexts;
    public LogMouseSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _contexts.game.CreateEntity().AddHelloWorld("left mouse down");
        }
    }
}