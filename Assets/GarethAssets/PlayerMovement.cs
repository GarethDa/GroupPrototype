using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float forwardSpeed = .5f;
    [SerializeField] float sidewaysSpeed = .5f;
    [SerializeField] CharacterController cController;

    float horizInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cController.Move(gameObject.transform.forward * forwardSpeed + gameObject.transform.right * horizInput * sidewaysSpeed);
    }

    public void OnMove(InputAction.CallbackContext cntxt)
    {
        horizInput = cntxt.ReadValue<float>();
    }
}
