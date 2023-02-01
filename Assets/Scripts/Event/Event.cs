using System;

#region 泛型事件类
public class Event<T> where T : Event<T>
{
    private static Action _myOnEvent;
    /// <summary>
    /// 注册事件
    /// </summary>
    public static void Register(Action onEvent)
    {
        _myOnEvent += onEvent;
    }
    /// <summary>
    /// 注销事件
    /// </summary>
    public static void UnRegister(Action onEvent)
    {
        _myOnEvent -= onEvent;
    }
    /// <summary>
    /// 触发事件
    /// </summary>
    public static void Tigger()
    {
        _myOnEvent?.Invoke();
    }

}
#endregion

#region 可传参的泛型事件重载类
public class Event<T, TT> where T : Event<T, TT>
{
    private static Action<TT> _myOnEvent;
    /// <summary>
    /// 注册事件
    /// </summary>
    public static void Register(Action<TT> onEvent)
    {
        _myOnEvent += onEvent;
    }
    /// <summary>
    /// 注销事件
    /// </summary>
    public static void UnRegister(Action<TT> onEvent)
    {
        _myOnEvent -= onEvent;
    }
    /// <summary>
    /// 触发事件
    /// </summary>
    public static void Tigger(TT t)
    {
        _myOnEvent?.Invoke(t);
    }
}
#endregion
