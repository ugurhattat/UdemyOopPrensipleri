using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventOrnek : MonoBehaviour
{
    [SerializeField] UnityEvent unityEvent;
    //public delegate void OrnekDelegate();
    //public event OrnekDelegate OrnekDelegateEvent;
    //public event Action OrnekDelegateEvent;
    //public event Func<int, int, string> OrnekDelegateEvent;
    public event System.Action<int> OrnekDelegateEvent;

    int _sayi;
    private void OnEnable()
    {
        _sayi++;
        OrnekDelegateEvent?.Invoke(_sayi);
        unityEvent?.Invoke();
        SingletonObject.Instance.SingletonObjectMethod();
    }
}
