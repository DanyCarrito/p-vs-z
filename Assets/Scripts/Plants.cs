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
    private float bounce = 0;
    private const float dTime = 0.1f;
    public  GameObject selectedPlant;
    public Transform myPosition;

    private InputAction selectAction;
    private Camera mainCamera;

    public LayerMask plantLayer; 
    public LayerMask groundLayer;

    private void Start()
    {
        selectAction = InputSystem.actions.FindAction("Place");
    }

    private void Update()
    {
       
        selectAction.performed += context =>
        {
            Instantiate(selectedPlant, myPosition.position, Quaternion.identity);
            Debug.Log("lol");
        };
        float touchValue = selectAction.ReadValue<float>();

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
        Ray ray = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, plantLayer))
        {
            selectedPlant = hit.collider.gameObject; 
        }
        else if (selectedPlant != null && Physics.Raycast(ray, out hit, Mathf.Infinity, groundLayer))
        {
            selectedPlant.transform.position = hit.point; 
        }
    }

}
