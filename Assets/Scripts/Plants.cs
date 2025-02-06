using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public enum TypePlants {
    type1,
    type2
};

public class Plants : MonoBehaviour
{
    public bool isType1;
    public bool isType2;
    public bool isTouchPressed = false;
    public  GameObject selectedPlant;
    public Transform myPosition;

    private InputAction selectAction;
    private InputAction pressPos;
    private Camera mainCamera;

    public LayerMask plantLayer; 
    public LayerMask groundLayer;

    private void Start()
    {
        selectAction = InputSystem.actions.FindAction("Place");
        pressPos = InputSystem.actions.FindAction("PressPosition");
    }

    private void Update()
    {
       
        selectAction.performed += context =>
        {
            //PlacePlant();
            Debug.Log("lol");
        };
        float touchValue = selectAction.ReadValue<float>();
        Vector2 pos = pressPos.ReadValue<Vector2>();
        Debug.Log(pos);

    }


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

    private void PlacePlant()
    {
        ////Vector2 pos = pressPos.ReadValue<Vector2>();
        ////Ray ray = mainCamera.ScreenPointToRay(pos);
        //RaycastHit hit;

        //if (Physics.Raycast(ray, out hit, Mathf.Infinity, plantLayer))
        //{
        //    Instantiate(selectedPlant, hit.point, Quaternion.identity);
        //}
        ////else if (selectedPlant != null && Physics.Raycast(ray, out hit, Mathf.Infinity, groundLayer))
        ////{
        ////    selectedPlant.transform.position = hit.point; 
        ////}
    }

}
