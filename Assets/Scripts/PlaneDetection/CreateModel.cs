using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateModel : MonoBehaviour
{
    private ARInteractionManager interactionManager;
    [SerializeField] GameObject modelo;
    [SerializeField] public GameObject panel;
    void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(() => panel.transform.DOScale(new Vector3(0, 0, 0), 0.3f));
        button.onClick.AddListener(GameManager.instance.ArPosition);
        button.onClick.AddListener(Create3DModel);
        interactionManager = FindAnyObjectByType<ARInteractionManager>();
    }

    private void Create3DModel()
    {
        //CREAR LOS MODELOS
        //Instantiate(item3DModel);
        //CREAR Y ASIGNAR LOS MODELOS
        interactionManager.Item3DModel = Instantiate(modelo);
        
    }
}
