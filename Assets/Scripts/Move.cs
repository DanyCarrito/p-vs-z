//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.InputSystem;
//public class Move : MonoBehaviour
//{
//    public float speedMove;
//    private InputAction moveAction;
//    private InputAction selectionAction;
//    private InputAction dondeAction;

//    // Start is called before the first frame update
//    void Start()
//    {
//        //moveAction = InputSystem.actions.FindAction("Move");
//        selectionAction = InputSystem.actions.FindAction("Select");
//        dondeAction = InputSystem.actions.FindAction("PosClick");
//        Debug.Log("width: " + Screen.width);
//        Debug.Log("height: " + Screen.height);
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        float cascaValue = selectionAction.ReadValue<float>();
//        Vector2 onteValue = dondeAction.ReadValue<Vector2>();

//        if( cascaValue > 0.1f ) 
//        {
//            if (onteValue.x > Screen.width / 2)
//            {
//                gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
//                //Debug.Log("more " +  onteValue.x);
//            }
//            else
//            {
//                gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
//                //Debug.Log("more " + onteValue.x);
//            }
//        }

//        //Vector2 moveValue = moveAction.ReadValue<Vector2>();
//        //transform.position += new Vector3(moveValue.x, 0, moveValue.y) * (Time.deltaTime * speedMove);
//    }
//}
