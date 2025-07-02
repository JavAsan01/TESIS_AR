using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
   
    public event Action OnMainMenu;
    //public event Action OnCameraMenu;
    public event Action OnArPositionMenu;
    public event Action OnItemsMenu;
    public event Action OnZorroPanel;
    public event Action OnConfirmMenu;
    private Animator animator;
    [SerializeField] private AnimationClip animacionFinal;

    //Escena Informcion
    public event Action OnInicioInfo; 
    public event Action OnHistoria;
    public event Action OnInformacion;
    public event Action OnConsejo;
    public event Action OnMapas;
    public event Action OnRutas;

    //Funcion de las transiciones
    public TransicionEscena Te;

    public static GameManager instance;
    private void Awake()
    { // Que solo existan una instancia de GameManager
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        MainMenu();
        animator = GetComponent<Animator>();
    }

    public void MainMenu()
    { //Funcion para activar el menu Main
        OnMainMenu?.Invoke();
        Debug.Log("Main menu Activado");
    }

    public void ItemsMenu()
    { //Funcion para activar el menu Main
        OnItemsMenu?.Invoke();
        Debug.Log("Items menu Activado");
    }

    public void ArPosition()
    { //Funcion para activar el menu Main
        OnArPositionMenu?.Invoke();
        Debug.Log("Ar menu Activado");
    }
    public void ConfirmMenu()
    { //Funcion para activar el menu Main
        OnConfirmMenu?.Invoke();
        Debug.Log("Menu Cerrado Activado");
    }

    public void CloseApp()
    { //Funcion para cerrar la aplicacion
        Debug.Log("Aplicacion Cerrada");
        Application.Quit();
    }

    public void CargarEscenario(string nombreEscena)
    { //Funcion para cargar la escena de la camara Ar 
        //_animacion.cambiarEscenario()
        Te.Cambiar(nombreEscena);
        
    }
    public void ZorroPanel()
    { //Funcion para activar el menu Main
        OnZorroPanel?.Invoke();
        Debug.Log("Zorro activado");
    }

    //Escena Informacion
    public void InicioInfo()
    { //Funcion para activar
        OnInicioInfo?.Invoke();
        Debug.Log("Inicio Activado");
    }
    public void Historia()
    { //Funcion para activar
        OnHistoria?.Invoke();
        Debug.Log("Historia Activado");
    }
    public void Informacion()
    { //Funcion para activar
        OnInformacion?.Invoke();
        Debug.Log("Informacion Activado");
    }
    public void Consejo()
    { //Funcion para activar
        OnConsejo?.Invoke();
        Debug.Log("Consejo Activado");
    }
    public void Mapas()
    { //Funcion para activar
        OnMapas?.Invoke();
        Debug.Log("Mapas Activado");
    }
    public void Rutas()
    { //Funcion para activar
        OnRutas?.Invoke();
        Debug.Log("Rutas Activado");
    }

}
