using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("start");
        Console.WriteLine("Hello!");
    }

    // Update is called once per frame
    void Update()
    {
      print(transform.position);
      transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
