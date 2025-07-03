using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateOrnek : MonoBehaviour
{
    //[SerializeField] EventOrnek _eventOrnek;
    //bu delegate'miz geriye deger dondurmeye ve parametre almayan methodlarin elciligi
    public delegate void DelegateOrnek1();

    //bu delegate'miz geriye deger dondurmeyen ve iki int parametresi alan methodlarin elciligi
    public delegate void DelegateOrnek2(int sayi1, int sayi2);

    //DelegateOrnek1 _delegateOrnek1;
    DelegateOrnek2 _delegateOrnek2;
    EventOrnek _eventOrnek;

    //private void Awake()
    //{
    //    DelegateOrnek2 delegateOrnek2 = new DelegateOrnek2(ParametreAlanDegerDondurmeyenOrnek1);
    //    delegateOrnek2 += ParametreAlanDegerDondurmeyenOrnek2;
    //    delegateOrnek2 += ParametreAlanDegerDondurmeyenOrnek3;

    //    delegateOrnek2(30, 20);

    //    _delegateOrnek2 = new DelegateOrnek2(ParametreAlanDegerDondurmeyenOrnek1);
    //    _delegateOrnek2 += ParametreAlanDegerDondurmeyenOrnek2;
    //    _delegateOrnek2 += ParametreAlanDegerDondurmeyenOrnek3;

    //    delegateOrnek2(30, 20);
    //}

    private void Awake()
    {
        _eventOrnek = FindObjectOfType<EventOrnek>();
        //iki component class ayni nesne uzerinde ise bu code calisir ama degilse calismaz
       //_eventOrnek = GetComponent<EventOrnek>(); 
    }

    private void OnEnable()
    {
        _eventOrnek.OrnekDelegateEvent += HandleOrnekDelegateEvent;
    }

    private void OnDisable()
    {
        _eventOrnek.OrnekDelegateEvent -= HandleOrnekDelegateEvent;
    }

    private void HandleOrnekDelegateEvent(int sayi)
    {
        Debug.Log("OrnekDelegateEvent tetiklendi...." + sayi);
    }

    //private void Start()
    //{
    //    _delegateOrnek2?.Invoke(30, 20);
    //}

    //private void OnEnable()
    //{
    //    _delegateOrnek2?.Invoke(50, 60);
    //}

    //public void UnityEventOrnek()
    //{
    //    Debug.Log("Unity Event ornek tetiklendi");
    //}

    private void DelegateOrnek1Ornek()
    {
        DelegateOrnek1 delegateOrnek1 = new DelegateOrnek1(ParametreAlmayanDegerDondurmeyenOrnek1);
        delegateOrnek1 += ParametreAlmayanDegerDondurmeyenOrnek2;
        delegateOrnek1 += ParametreAlmayanDegerDondurmeyenOrnek3;
        delegateOrnek1 += ParametreAlmayanDegerDondurmeyenOrnek4;

        delegateOrnek1 -= ParametreAlmayanDegerDondurmeyenOrnek4;

        //if (delegateOrnek1 != null)
        //{
        //    delegateOrnek1.Invoke();
        //}

        //if (_delegateOrnek1 != null)
        //{
        //    _delegateOrnek1();
        //}

        //_delegateOrnek1?.Invoke();

        delegateOrnek1.Invoke();
    }

    private void ParametreAlmayanDegerDondurmeyenOrnek1()
    {
        Debug.Log("ParametreAlmayanDegerDondurmeyenOrnek1 calisti");
    }

    private void ParametreAlmayanDegerDondurmeyenOrnek2()
    {
        Debug.Log("ParametreAlmayanDegerDondurmeyenOrnek2 calisti");
    }

    private void ParametreAlmayanDegerDondurmeyenOrnek3()
    {
        Debug.Log("ParametreAlmayanDegerDondurmeyenOrnek3 calisti");
    }

    private void ParametreAlmayanDegerDondurmeyenOrnek4()
    {
        Debug.Log("ParametreAlmayanDegerDondurmeyenOrnek4 calisti");
    }

    private void ParametreAlanDegerDondurmeyenOrnek1(int sayi1, int sayi2)
    {
        Debug.Log(sayi1 + sayi2);
    }

    private void ParametreAlanDegerDondurmeyenOrnek2(int sayi1, int sayi2)
    {
        Debug.Log(sayi1 - sayi2);
    }

    private void ParametreAlanDegerDondurmeyenOrnek3(int sayi1, int sayi2)
    {
        Debug.Log(sayi1 * sayi2);
    }
}