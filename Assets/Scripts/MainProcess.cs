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
}
