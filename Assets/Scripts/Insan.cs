using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class keyword'unu kullanarak bir insan tipi nesnesi olusturmus olduk
public class Insan
{
    //Access Modifier
    // en ozgur en erisilebilir olan public-internal-protected-private
    //private string _firstName;   new property kullanirken fieldlara ihtiyacimiz yoktur
    //private string _lastName;    new property kullanirken fieldlara ihtiyacimiz yoktur
    private int _age;

    public string FirstName { get; set; }

    //new property
    public string LastName { get; set; }

    //bu bir property'dir bu yazim turune old property denir
    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value < 1 || value > 110)
            {
                throw new System.Exception("Hatali yas girisi");
            }
            else
            {
                _age = value;
            }
        }
    }

    //en eski kapsulleme

    public void SetAge(int age)
    {
        _age = age;
    }

    //en eski kapsulleme
    public int GetAge() 
    {
        return _age;
    }
}
