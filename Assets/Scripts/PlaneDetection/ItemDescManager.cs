using DG.Tweening;
using UnityEngine;

public class ItemDescManager : MonoBehaviour
{
    [SerializeField] public GameObject panelZorro;
    [SerializeField] public GameObject panelCiervo;
    [SerializeField] public GameObject panelCondor;
    [SerializeField] public GameObject panelOso;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void zorro() 
    { 
        panelZorro.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
    }
}
