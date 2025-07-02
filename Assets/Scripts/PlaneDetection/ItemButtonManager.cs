using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ItemButtonManager : MonoBehaviour
{
    private string itemName;
    private string itemDescription;
    private Sprite itemImage;
    private GameObject item3DModel;
    //Referenciar al Script de ARInteractionManager
    private ARInteractionManager interactionManager;

    public string ItemName { set => itemName = value; }
    public string ItemDescription { set => itemDescription = value; }
    public Sprite ItemImage{ set => itemImage = value; }
    public GameObject Item3DModel { set => item3DModel = value; }

    //[SerializeField] TextMeshPro nombre;
    //[SerializeField] TextMeshPro descripcion;
    //[SerializeField] Sprite imagen;
    //[SerializeField] GameObject modelo;
    [SerializeField] public GameObject panel;
    //[SerializeField] public GameObject ItemsMenu;


    // Start is called before the first frame update
    void Start()
    {
        //GameManager.instance.OnDescMenu += ActivateDescMenu;
        //transform.GetChild(0).GetComponent<TextMeshProUGUI>().text= itemName;
        //transform.GetChild(1).GetComponent<RawImage>().texture= itemImage.texture;
        //transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = itemDescription;

        var button = GetComponent<Button>();
        //button.onClick.AddListener(GameManager.instance.DescMenu);
        //button.onClick.AddListener(GameManager.instance.DescMenu);
        button.onClick.AddListener(GameManager.instance.ArPosition);
        button.onClick.AddListener(() => panel.transform.DOScale(new Vector3(1, 1, 1), 0.3f));

        //button.onClick.AddListener(Create3DModel);

        //Fucnion del pointer
        interactionManager = FindAnyObjectByType<ARInteractionManager>();
    }

    //private void Create3DModel()
    //{
        //CREAR LOS MODELOS
        //Instantiate(item3DModel);
        //CREAR Y ASIGNAR LOS MODELOS
    //    interactionManager.Item3DModel = Instantiate(modelo);

    //}

 
}
