using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class CleanupSystem : IExecuteSystem
{
    private IGroup<GameEntity> _group;
    public CleanupSystem(Contexts contexts)
    {
        _group = contexts.game.GetGroup(GameMatcher.HelloWorld);
    }

    public void Execute()
    {
        foreach (var e in _group.GetEntities())
        {
            e.Destroy();
        }
    }
}
