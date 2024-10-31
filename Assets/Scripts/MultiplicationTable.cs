using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    //assignment10
           int Multiply (int no1,int no2){
            return no1*no2;
        }
   
        for(int i=1;i<=10;i++){
            int n=5;
            Debug.Log($"{n}x{i}= {Multiply(n,i)}");
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
