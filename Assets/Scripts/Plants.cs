using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypePlants {
    type1,
    type2
};

public class Plants : MonoBehaviour
{
    public bool isType1;
    public bool isType2;


    public void ChangeType(TypePlants type)
    {
        switch (type)
        {
            case TypePlants.type1:
                break;
            case TypePlants.type2:
                break;
        }
    }

    public void ButtonType1()
    {
        ChangeType(TypePlants.type1);
    }

    public void ButtonType2()
    {
        ChangeType(TypePlants.type2);
    }

}
