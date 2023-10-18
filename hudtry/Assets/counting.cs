using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class counting : MonoBehaviour
{
    public InputField a1;
    public InputField a2;
    public InputField a3;
    public InputField a4;
    public InputField a5;
    public InputField a6;




    public Text textou;
    float sum;
    

    // Start is called before the first frame update
    void Start()
    {
      
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }

    public void count()
    {
        sum = (Int32.Parse(a1.text) + Int32.Parse(a2.text) + Int32.Parse(a3.text) + Int32.Parse(a4.text) + Int32.Parse(a5.text)) * Int32.Parse(a6.text) + 100;
        textou.text = sum.ToString();
    }



}
