using UnityEngine;

public class ControladorPopUp : MonoBehaviour
{
    public GameObject popUp1;
    public GameObject popUp2;
    public GameObject popUp3;
    public GameObject popUp4;
    public GameObject popUp5;
    public GameObject popUp6;
    public GameObject popUp7;

    void Start()
    {
        // Oculta el Pop Up al inicio
        popUp1.SetActive(false);
        popUp2.SetActive(false);
        popUp3.SetActive(false);
        popUp4.SetActive(false);
        popUp5.SetActive(false);
        popUp6.SetActive(false);
        popUp7.SetActive(false);
    }

    public void MostrarPopUp1()
    {
        popUp1.SetActive(true);
    }

    public void MostrarPopUp2()
    {
        popUp2.SetActive(true);
    }

    public void MostrarPopUp3()
    {
        popUp3.SetActive(true);
    }
    public void MostrarPopUp4()
    {
        popUp4.SetActive(true);
    }
    public void MostrarPopUp5()
    {
        popUp5.SetActive(true);
    }
    public void MostrarPopUp6()
    {
        popUp6.SetActive(true);
    }
    public void MostrarPopUp7()
    {
        popUp7.SetActive(true);
    }
    void Update()
    {
        // Cierra los Pop Ups al hacer clic fuera de ellos
        if (Input.GetMouseButtonDown(0))
        {
            CerrarPopUp();
        }
    }

    void CerrarPopUp()
    {
        GameObject[] popUps = { popUp1, popUp2, popUp3, popUp4, popUp5, popUp6, popUp7 };

        foreach (GameObject popUp in popUps)
        {
            if (popUp.activeSelf && !RectTransformUtility.RectangleContainsScreenPoint(popUp.GetComponent<RectTransform>(), Input.mousePosition))
            {
                popUp.SetActive(false);
            }
        }
    }

}
