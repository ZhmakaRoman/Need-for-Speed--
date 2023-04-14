using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{ 
   [SerializeField]
   private float _speed;
   

   private void Update()
   {
       var position = gameObject.transform.position;
       Debug.Log(position);

       //чтобы машинка двигалась равномерно на необходимо время прошедшие за кадр
       var step = _speed * Time.deltaTime;

       if (Input.GetKey(KeyCode.W))
       {
           position.z +=step;
       }
       else if (Input.GetKey(KeyCode.S))
       {
           position.z -=step;
       }
       else if (Input.GetKey(KeyCode.D))
       {
           position.x +=step;
       }
       else if (Input.GetKey(KeyCode.A))
       {
           position.x -=step;
       }
     
       transform.position = position;
       Debug.Log(position);
   }
}
