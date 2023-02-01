using System;

#region �����¼���
public class Event<T> where T : Event<T>
{
    private static Action _myOnEvent;
    /// <summary>
    /// ע���¼�
    /// </summary>
    public static void Register(Action onEvent)
    {
        _myOnEvent += onEvent;
    }
    /// <summary>
    /// ע���¼�
    /// </summary>
    public static void UnRegister(Action onEvent)
    {
        _myOnEvent -= onEvent;
    }
    /// <summary>
    /// �����¼�
    /// </summary>
    public static void Tigger()
    {
        _myOnEvent?.Invoke();
    }

}
#endregion

#region �ɴ��εķ����¼�������
public class Event<T, TT> where T : Event<T, TT>
{
    private static Action<TT> _myOnEvent;
    /// <summary>
    /// ע���¼�
    /// </summary>
    public static void Register(Action<TT> onEvent)
    {
        _myOnEvent += onEvent;
    }
    /// <summary>
    /// ע���¼�
    /// </summary>
    public static void UnRegister(Action<TT> onEvent)
    {
        _myOnEvent -= onEvent;
    }
    /// <summary>
    /// �����¼�
    /// </summary>
    public static void Tigger(TT t)
    {
        _myOnEvent?.Invoke(t);
    }
}
#endregion
