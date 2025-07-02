using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemDoor : MonoBehaviour
{
    void Update()
    {
        //EXECUTE THE NEXT FUNCTION INSIDE UPDATE
        CheckIfCameraIsLooking();
    }

    //BEGIN C#    
    //VARIABLES
    public Transform originObject;
    public Transform lookingCameraTransform;
    public Animation animator;
    [SerializeField] private AnimationClip abrir;
    [SerializeField] private AnimationClip cerrar;
    [Range(0f, 1f)]
    public float sensitivity = 0.4f;
    Vector3 forwardVectorTowardsCamera;
    bool cameraLooking;
    float dotProductResult;
    void Start()
    {
        // Obtén el componente Animation
        animator = GetComponent<Animation>();

        // Asegúrate de que el Animation y los clips no sean nulos
        if (animator != null && abrir != null && cerrar != null)
        {
            // Asigna los clips al componente Animation
            animator.AddClip(abrir, abrir.name);
            animator.AddClip(cerrar, cerrar.name);
        }
    }



    //FUNCTIONS
    public void CheckIfCameraIsLooking()
    {

        forwardVectorTowardsCamera = (lookingCameraTransform.position - originObject.position).normalized;
        dotProductResult = Vector3.Dot(lookingCameraTransform.forward, forwardVectorTowardsCamera);
        if (cameraLooking)
        {
            if (dotProductResult > sensitivity)
            {
                cameraLooking = false;
                StartNotLooking();

            }
        }
        else
        {
            if (dotProductResult < -sensitivity)
            {
                cameraLooking = true;
                StartLooking();
            }
        }
        if (cameraLooking)
        {
            PlayerIsLooking();
        }
        else
        {
            PlayerIsNotLooking();

        }
    }

    void StartLooking()
    {
        ReproducirAnimacion(abrir.name);
        Debug.Log("Camera starts looking");

    }
    void PlayerIsLooking()
    {
        Debug.Log("Camera is currently looking");

    }

    void StartNotLooking()
    {

        //ReproducirAnimacion(cerrar.name);
        Debug.Log("Camera stops looking");
    }

    void PlayerIsNotLooking()
    {
       
    }
    //C# ENDS
    void ReproducirAnimacion(string nombreAnimacion)
    {
        // Asegúrate de que el Animation no sea nulo
        if (animator != null)
        {
            // Detén cualquier animación actual antes de reproducir una nueva
            animator.Stop();

            // Reproduce la animación por su nombre
            animator.Play(nombreAnimacion);
        }
    }
}
