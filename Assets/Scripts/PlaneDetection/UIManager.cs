using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField] public GameObject mainMenuCanvas;
    [SerializeField] public GameObject ItemsMenuCanvas;
    [SerializeField] public GameObject ArPositionCanvas;
    [SerializeField] public GameObject DescMenuCanvas;


    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.OnMainMenu += ActivateMainMenu;
        GameManager.instance.OnItemsMenu+= ActivateItemsMenu;
        GameManager.instance.OnArPositionMenu += ActivateArPositionMenu;
        GameManager.instance.OnConfirmMenu += ConfirmRa;
        GameManager.instance.OnZorroPanel += ActivateZorroPanel;

        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);


    }

    private void ActivateZorroPanel()
    {

        DescMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1,1, 1), 0.3f);
        //DescMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        //DescMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
    }

    private void ActivateMainMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1),0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1),0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1),0.3f);


        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0),0.5f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0),0.3f);

        ItemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        ArPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ArPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }
    private void ActivateItemsMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);


        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        ItemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(700, 0.3f);

        DescMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }

    private void ActivateArPositionMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);


        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        ItemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        ArPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ArPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        //DescMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
    }

    private void ConfirmRa() {
        mainMenuCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
    }
}
