using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class UIManagerPortal : MonoBehaviour
{
    [SerializeField] public GameObject mainMenu;
    [SerializeField] public GameObject ItemsMenu;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.OnMainMenu += ActivarMainMenu;
        GameManager.instance.OnItemsMenu += ActivarItemsMenu;
        GameManager.instance.OnConfirmMenu += ConfirmRa;

        mainMenu.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        //mainMenu.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }
    private void ActivarMainMenu()
    {
        mainMenu.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenu.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        //mainMenu.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);


        ItemsMenu.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsMenu.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        ItemsMenu.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

    }
    private void ActivarItemsMenu()
    {
        mainMenu.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenu.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        //mainMenu.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);


        ItemsMenu.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ItemsMenu.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        ItemsMenu.transform.GetChild(1).transform.DOMoveY(700, 0.3f);
    }

    private void ConfirmRa()
    {
        mainMenu.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenu.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        //mainMenu.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
    }


}
