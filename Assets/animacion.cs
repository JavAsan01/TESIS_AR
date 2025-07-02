using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class animacion : MonoBehaviour
{
    [SerializeField] private Transform panelSlogan, panelTitulo;
    public Vector3 posicionFinal = new Vector3(2, 0, 0);
    public float Slogan = 1600;
    public float Titulo = 1600;
    //Realizar animaciones
    void Start()
    {
        //panelSlogan.DOScale(Vector3.zero, 0.5f).SetEase(Ease.InBounce);
        transform.DOMoveY(Slogan, 2).SetEase(Ease.InOutSine).SetLoops(-1,loopType:LoopType.Yoyo);
        //panelSlogan.DOShakePosition(
        //    duration:0.5f,
        //    strength:0.5f,
        //    vibrato:10
        //    );
    }
}
