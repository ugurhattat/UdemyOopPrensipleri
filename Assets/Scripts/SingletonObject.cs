using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonObject : MonoBehaviour
{
    public static SingletonObject Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        //NormalClassSingletonOrnek normalClassSingletonOrnek1 = new NormalClassSingletonOrnek(); //101
        // NormalClassSingletonOrnek normalClassSingletonOrnek2 = new NormalClassSingletonOrnek(); //102
        // NormalClassSingletonOrnek normalClassSingletonOrnek3 = new NormalClassSingletonOrnek(); //103
        // NormalClassSingletonOrnek normalClassSingletonOrnek4 = new NormalClassSingletonOrnek(); //104

        NormalClassSingletonOrnek normalClassSingletonOrnek1 =NormalClassSingletonOrnek.Instance(); //101
        NormalClassSingletonOrnek normalClassSingletonOrnek2 = NormalClassSingletonOrnek.Instance(); //101
        NormalClassSingletonOrnek normalClassSingletonOrnek3 = NormalClassSingletonOrnek.Instance(); //101
        NormalClassSingletonOrnek normalClassSingletonOrnek4 = NormalClassSingletonOrnek.Instance(); //101
    }

    public void SingletonObjectMethod()
    {
        Debug.Log("Singleton Object method calisti");
    }
}

class NormalClassSingletonOrnek
{

    private static NormalClassSingletonOrnek _instance;
    private NormalClassSingletonOrnek()
    {

    }

    public static NormalClassSingletonOrnek Instance()
    {
        if (_instance == null)
        {
            _instance = new NormalClassSingletonOrnek();
        }

        return _instance;
    }
}
