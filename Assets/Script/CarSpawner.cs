using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    //создаем поле в которм будет хранится наш обЪект
    [SerializeField]
    private GameObject _prefab;
    //устанавливаем объект на сцене
   private void Awake()
   {
       Instantiate(_prefab);
   }
}
