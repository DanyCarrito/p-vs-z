using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeEnemies
{
    enemy1,
    enemy2, 
}

public class Enemy : MonoBehaviour
{
    public float speed;
    public float speedEnemy1;
    public float speedEnemy2;


    private void Start()
    {
       int decision = Random.Range(1, 3);
        if(decision == 1)
        {
            ChangeType(TypeEnemies.enemy1);
        }
        else
        {
            ChangeType(TypeEnemies.enemy2);
        }
    }
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }



    public void ChangeType(TypeEnemies type)
    {
        switch (type)
        {
            case TypeEnemies.enemy1:
                VariablesEnemy1();
                break;
            case TypeEnemies.enemy2:
                VariablesEnemy2();
                break;
        }
    }

    public void VariablesEnemy1()
    {
        speed = speedEnemy1;
        Debug.Log("11111");
    }

    public void VariablesEnemy2()
    {
        speed = speedEnemy2;
        Debug.Log("222222");
    }
}
