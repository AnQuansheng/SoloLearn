//****************************************************************************
// Description:
// Author: hiramtan@live.com
//****************************************************************************

using Entitas;
public class CreatSystem : IInitializeSystem
{
    private Contexts _contexts;
    public CreatSystem(Contexts contexts)
    {
        _contexts = contexts;
    }
    public void Initialize()
    {
        var e = _contexts.game.CreateEntity();
        e.AddHelloWorld("hello world");
    }
}