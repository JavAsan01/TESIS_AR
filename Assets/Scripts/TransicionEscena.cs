using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicionEscena : MonoBehaviour
{
    private Animator animator;

    [SerializeField] private AnimationClip animacionFinal;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    public void Cambiar(string escena) {

        //Debug.Log("Perro");
        StartCoroutine(CambiarEscena(escena));
        
    }

    IEnumerator CambiarEscena( string nombre )
    {
        animator.SetTrigger("Iniciar");
        yield return new WaitForSeconds(animacionFinal.length);
        SceneManager.LoadScene(nombre);
    }
}
