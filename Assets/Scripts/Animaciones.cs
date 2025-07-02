using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Animaciones : MonoBehaviour
{
    [SerializeField] private Transform panel;
    public Vector3 Escala = new Vector3(0,0,0);
    public float ejeY = 0;
    //public float Slogan = 1600;
    //public float Titulo = 1600;
    //public float btnInicio = 700;
    //public float btnCerrar = 700;
    //Realizar animaciones
    void Start()
    {
        panel.DOScale(Escala, 2).SetEase(Ease.InOutSine).SetLoops(-1, loopType:LoopType.Yoyo);
        panel.DOMoveY(ejeY, 2).SetEase(Ease.InOutSine).SetLoops(-1, loopType: LoopType.Yoyo);
        //panelTitulo.DOMoveY(Titulo, 2).SetEase(Ease.InOutSine).SetLoops(-1, loopType: LoopType.Yoyo);
        //btnEmpezar.DOMoveY(btnInicio, 2).SetEase(Ease.InOutSine).SetLoops(-1, loopType: LoopType.Yoyo);
        //btnSalir.DOMoveY(btnCerrar, 2).SetEase(Ease.InOutSine).SetLoops(-1, loopType: LoopType.Yoyo);
        //panelSlogan.DOShakePosition(
        //    duration:0.5f,
        //    strength:0.5f,
        //    vibrato:10
        //    );
    }
}