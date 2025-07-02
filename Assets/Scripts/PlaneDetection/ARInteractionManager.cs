using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARInteractionManager : MonoBehaviour
{
    [SerializeField] private Camera aRCamera;
    private ARRaycastManager aRRaycastManager;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    //GAME OBJECT DEL CAMPO
    private GameObject item3DModel;
    //GAME OBJECT DEL POINTER
    private GameObject aRPointer;

    //CREAR VARIALBE BOOL PARA LA FUNCION UPDATE
    //Posicion inicial
    private bool isInitialPosition;
    //Touch
    private bool isOverUI;
    //Guardar la pos inicial de los dos touch
    private Vector2 initialTouchPos;
    //Saber si estoy sobre el modelo 3D
    private bool isOver3DModel;
    //Asignar temporalmente el modelo 3D seleccionado
    private GameObject itemSelected;

    //Escalar Objeto
    private float touchDis;
    private Vector2 touchPositionDiff;
    private float scaleTolerance = 25f;
    private float rotationTolerance = 1.5f;
    //private Vector2 touchPositionDiff;

    public GameObject Item3DModel
    {
        set { 
            item3DModel = value;
            item3DModel.transform.position = aRPointer.transform.position;
            item3DModel.transform.parent = aRPointer.transform;
            //Asignar valor true para cuando se coloque
            isInitialPosition = true;
        }
    }


    void Start()
    {
        aRPointer = transform.GetChild(0).gameObject ;
        aRRaycastManager = FindAnyObjectByType<ARRaycastManager>();
        //FUNCION QUE PERMITE FIJAR EL MODELO 3D
        GameManager.instance.OnMainMenu += SetItemPosition; 
    }


    // Update is called once per frame
    void Update()
    {
        //ASIGNAR LA POSICION INICAL AL MODELO 3D CREADO
        //ENCONTRAR PUNTO EN EL PLANO
        if (isInitialPosition)
        {
            Vector2 middlePointScreen = new Vector2(Screen.width/2, Screen.height/2);
            aRRaycastManager.Raycast(middlePointScreen, hits, TrackableType.Planes);
            //Encuentra un plano
            if (hits.Count > 0)
            {
                transform.position = hits[0].pose.position;
                transform.rotation = hits[0].pose.rotation;
                //Mostrar el pointer
                aRPointer.SetActive(true);
                isInitialPosition = false;
            }

        }
        //FUNCION PARA MOVER OBJETOS EN LA PANTALLA
        //PRIMERO VERIFICAR UN INPUT(EN ESTE CASO, VERIFICAR SI SE A TOCADO LA PANTALLA)
        if (Input.touchCount>0)
        {
            Touch touchOne = Input.GetTouch(0);
            //Verificar si el boton no ha sido en un boton de la interfaz
            if (touchOne.phase == TouchPhase.Began)
            {
                var touchPosition = touchOne.position;
                isOverUI = isTapOverUi(touchPosition);
                isOver3DModel = isTapOver3DModel(touchPosition);
            }
            if (touchOne.phase == TouchPhase.Moved)//Mover el dedo en la pantalla
            {
                //verificar si el mov es dentro de los planos detectados en RA
                if (aRRaycastManager.Raycast(touchOne.position, hits, TrackableType.Planes))
                {
                    Pose hitPose = hits[0].pose;
                    //sino fue sobre la interfaz
                    if (!isOverUI && isOver3DModel) { 
                        transform.position = hitPose.position;  
                    }
                }
            }
            //ROTAR OBJETOS EN RA
            if (Input.touchCount == 2)
            {
                Touch touchTwo = Input.GetTouch(1);
                //VERIFICAR SI HAN EMPEZADO
                if (touchOne.phase == TouchPhase.Began || touchTwo.phase == TouchPhase.Began)
                {
                    touchPositionDiff = touchTwo.position - touchOne.position;
                    touchDis = Vector2.Distance(touchTwo.position, touchOne.position);
                }
                //VEERIFICAR SI LOS TOUCH SE MUEVEN, MOVER LOS DEDOS
                if (touchOne.phase == TouchPhase.Moved || touchTwo.phase == TouchPhase.Moved)
                {
                    Vector2 currentTouchPos = touchTwo.position - touchOne.position;
                    //DISTANCIA Escalar
                    float curretnTouchDis = Vector2.Distance(touchTwo.position, touchOne.position);
                    float diffDistance = curretnTouchDis - touchDis;
                    if (Mathf.Abs(diffDistance) >  scaleTolerance)
                    {
                        Vector3 newScale = item3DModel.transform.localScale + Mathf.Sign(diffDistance) * Vector3.one * 0.1f;
                        item3DModel.transform.localScale = Vector3.Lerp(item3DModel.transform.localScale,newScale,0.05f);
                    }
                    //CALCUCAR EL ANGULO ENTRE LAS DOS POSICIONES
                    float angle = Vector2.SignedAngle(touchPositionDiff, currentTouchPos);
                    //ROTAR EL MODELO #D
                    if (Mathf.Abs(angle) > rotationTolerance)
                    {
                        item3DModel.transform.rotation = Quaternion.Euler(0, item3DModel.transform.eulerAngles.y - angle, 0);
                    }
                    
                    touchPositionDiff = currentTouchPos;
                    touchDis = curretnTouchDis;
                    //initialTouchPos = currentTouchPos;
                }
            }

            if (isOver3DModel && item3DModel == null && !isOverUI)
            {
                GameManager.instance.ArPosition();
                item3DModel = itemSelected;
                itemSelected = null;
                aRPointer.SetActive(true);
                transform.position = item3DModel.transform.position;
                item3DModel.transform.parent = aRPointer.transform;
            }
        }
    }

    private bool isTapOver3DModel(Vector2 touchPosition)
    {
        Ray ray = aRCamera.ScreenPointToRay(touchPosition);
        //saber si se ha tocado un colaider
        if(Physics.Raycast(ray, out RaycastHit hit3DModel))
        {
            if (hit3DModel.collider.CompareTag("Item")) { //PASAMOS EL TAG QUE CREAMOS 
                itemSelected = hit3DModel.transform.gameObject;
                return true;
            }
        }
        return false;
    }

    private bool isTapOverUi(Vector2 touchPosition)
    {
        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = new Vector2 (touchPosition.x, touchPosition.y);
        List<RaycastResult> result =   new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, result);
        return result.Count > 0;
    }

    private void SetItemPosition()
    {
        //Verificar si el modelo se ha fijado
        if (item3DModel != null)
        {
            //En caso de fijar, quitar que sea "hijo" del pointer
            item3DModel.transform.parent = null;
            //Desactivar el pointer
            aRPointer.SetActive(false);
            item3DModel = null;
        }
    }

    //FUNCION para ELIMINAR el modelo 3D
    public void DelteItem() { 
        Destroy(item3DModel);
        aRPointer.SetActive(false);
        GameManager.instance.MainMenu();
    }
}
