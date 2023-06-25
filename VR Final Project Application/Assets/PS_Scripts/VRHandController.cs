using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VRHandController : MonoBehaviour
{
    [SerializeField] InputActionReference controllerActionGrip;
    [SerializeField] InputActionReference controllerActionTrigger;

    private Animator _handAnimator;

    private void Awake()
    {
        controllerActionGrip.action.performed += GripPress;
        controllerActionTrigger.action.performed += TriggerPress;

        controllerActionGrip.action.canceled += GripPress;
        controllerActionTrigger.action.canceled += TriggerPress;

        _handAnimator = GetComponent<Animator>();
    }

    private void GripPress(InputAction.CallbackContext obj)
    {
        _handAnimator.SetFloat("Grip", obj.ReadValue<float>());
    }

    private void GripPressEnd(InputAction.CallbackContext obj)
    {
        _handAnimator.SetFloat("Grip", 0);
    }

    private void TriggerPress(InputAction.CallbackContext obj)
    {
        _handAnimator.SetFloat("Trigger", obj.ReadValue<float>());
    }

    private void TriggerPressEnd(InputAction.CallbackContext obj)
    {
        _handAnimator.SetFloat("Trigger", 0);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
