using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainProcess : MonoBehaviour
{
    [Header("First Process Items")]
    public InputField firstNameFirstInput;
    public InputField lastNameFirstInput;
    public InputField ageFirstInput;

    [Header("Second Process Items")]
    public InputField firstNameSecondInput;
    public InputField lastNameSecondInput;
    public InputField ageSecondInput;

    [Header("Ornek")]
    [SerializeField] Text resultText;

    private void Start()
    {
        List<string> objectList = new List<string>();

        Product product1 = new Product
        {
            ID = 1,
            Name = "Product 1",
            Price = 20m
        };

        Product product2 = new Product
        {
            ID = 2,
            Name = "Product 2",
            Price = 23m
        };

        Product product3 = new Product
        {
            ID = 3,
            Name = "Product 3",
            Price = 24m
        };
        objectList.Add(product1.ToString());
        objectList.Add(product2.ToString());
        objectList.Add(product3.ToString());

        ProductStatic.ID = 4;
        ProductStatic.Name = "Product 4";
        ProductStatic.Price = 25m;

        ProductStatic.ID = 5;
        ProductStatic.Name = "Product 5";
        ProductStatic.Price = 21m;

        ProductStatic.ID = 6;
        ProductStatic.Name = "Product 6";
        ProductStatic.Price = 26m;

        objectList.Add(ProductStatic.GetMessage());
        objectList.Add(ProductStatic.GetMessage());
        objectList.Add(ProductStatic.GetMessage());
    }
    public void ButtonClick()
    {
        Insan insan1 = new Insan(); //instance ornegini almaktir int sayi = 10; demekle ayni sey //ram101
        insan1.FirstName = firstNameFirstInput.text;
        insan1.LastName = lastNameFirstInput.text;
        insan1.Age = int.Parse(ageFirstInput.text);
        //insan1.age = System.Convert.ToInt32(ageInput.text);

        //if (insan1.Age < 1 || insan1.Age > 200)
        //{
        //    insan1.Age = 18;
        //    Debug.LogError("Insan yasi 1'den kucuk veya 200'den buyuk olmaz");
        //    throw new System.Exception("Hata oldu");
        //}

        resultText.text = insan1.FirstName; // get islemi

        //Insan insan2 = new Insan();   //ram102
        //insan2.firstName = "Ilayda";
        //insan2.lastName = "Isik";
        //insan2.age = 27;
    }

    public void ButtonClickSecond()
    {
        Insan insan1 = new Insan();
        insan1.FirstName = firstNameFirstInput.text;
        insan1.LastName = lastNameFirstInput.text;
        insan1.Age = int.Parse(ageFirstInput.text);

        //if (insan1.Age < 1 || insan1.Age > 200)
        //{
        //    insan1.Age = 18;
        //    Debug.LogError("Insan yasi 1'den kucuk veya 200'den buyuk olmaz");
        //    throw new System.Exception("Hata oldu");
        //}
    }

    private void InheritanceOrnek()
    {
        Calisan calisan = new Calisan();
        calisan.FirstName = "Ugur";
        calisan.LastName = "Hattat";
        calisan.Age = 32;
        calisan.Salary = 60000;

        Musteri musteri = new Musteri
        {
            FirstName = "Ilayda",
            LastName = "Isik",
            Age = 27,
            BirthDate = DateTime.Now,
            CreditCardInfo1 = "1234567890"
        };
    }

    private void Ornek()
    {
        //Araba araba = new Araba();
        Bmw bmw1 = new Bmw("Bmw Model", "Bmw", 400f, 4, true, true, 10000m);
        bmw1.AlmanMi = true;
        bmw1.AlmanSatisYap();

        string resultMessage = "Bmw toplam Fiyati" + bmw1.ToplamFiyati;

        //bmw1.ToplamFiyati = 1000m; boyle onemli bir bilgiye disaridan deger atiyamamaliyiz

        Mercedes mercedes = new Mercedes();
        mercedes.Marka = "Mercedes";
        mercedes.Model = "Mercedes Model";
        mercedes.Hizi = 400f;
        mercedes.KapiSayisi = 4;
        mercedes.SifirMi = true;
        mercedes.YuzuyorMu = true;
        mercedes.Fiyati = 12000m;
        mercedes.AlmanMi = true;

        mercedes.SatisYap1();
        mercedes.AlmanSatisYap();

        string resultMercedes = "Mercedes toplam Fiyati" + mercedes.ToplamFiyati;

        Toyota toyota = new Toyota
        {

        };

        List<IAlman> almanArabalar = new List<IAlman>();
        almanArabalar.Add(bmw1);
        almanArabalar.Add(mercedes);

        List<Araba> arabalar = new List<Araba>
        {
            mercedes,
            bmw1,
            toyota
        };
    }
}
