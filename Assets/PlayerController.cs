using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] CharacterController characterController;
    void Start()
    {
        characterController.Move(new Vector3(10, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
