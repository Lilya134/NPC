using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCt: MonoBehaviour
{
     //Здоровье NPC
    public int health = 5;

     //Уровень NPC
    public int level = 1;

    //Скорость NPC
    public float speed = 1.2f;

    void Start()
    {
        health += level;       
    }

    void Update()
    {
        Vector3 newPosition = transform.position;

        newPosition.z += speed * Time.deltaTime;

        transform.position = newPosition;
    }
}
