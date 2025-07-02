using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class UIManagerInfo : MonoBehaviour
{
    [SerializeField] public GameObject InicioInfo;
    [SerializeField] public GameObject Historia;
    [SerializeField] public GameObject Informacion;
    [SerializeField] public GameObject Consejo;
    [SerializeField] public GameObject Mapas;
    [SerializeField] public GameObject Rutas;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.OnInicioInfo += ActivateInicioInfo;
        GameManager.instance.OnHistoria += ActivateHistoria;
        GameManager.instance.OnInformacion += ActivateInformacion;
        GameManager.instance.OnConsejo += ActivateConsejo;
        GameManager.instance.OnMapas += ActivateMapas;
        GameManager.instance.OnRutas += ActivateRutas;
        
        // Llamar al método para activar InicioInfo al inicio
        ActivateInicioInfo();
    }
    private void ActivateInicioInfo()
    {
        InicioInfo.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        Historia.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Informacion.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        Consejo.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Mapas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Rutas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }

    private void ActivateHistoria()
    {
        InicioInfo.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Historia.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
      
        Informacion.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        Consejo.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Mapas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Rutas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }
    private void ActivateInformacion()
    {
        InicioInfo.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Historia.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Informacion.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);

        Consejo.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Mapas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Rutas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }

    private void ActivateConsejo()
    {
        InicioInfo.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Historia.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Informacion.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        Consejo.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        Mapas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Rutas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }

    private void ActivateMapas()
    {
        InicioInfo.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Historia.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Informacion.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        Consejo.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Mapas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        Rutas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }

    private void ActivateRutas()
    {
        InicioInfo.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Historia.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Informacion.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        Consejo.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Mapas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        Rutas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
    }

}
