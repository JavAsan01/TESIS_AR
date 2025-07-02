using UnityEngine;

public class CambiarTextura : MonoBehaviour
{
    public GameObject esfera;
    public GameObject puerta;
    public Material[] m_Materiales;

    public AudioSource[] m_Audio;

    Renderer mRenderer;
    void Update()
    {
        
    }
    public void Museo_1()
    {
        Renderer mRend = esfera.GetComponent<Renderer>();
        if (m_Materiales.Length > 0)
        {
            mRend.material = m_Materiales[0];
            DetenerTodosLosAudiosExcepto(0);
            if (m_Audio[0].isPlaying)
            {
                m_Audio[0].Stop();
            }
            else
            {
                m_Audio[0].Play();
            }

        }
        else
        {
            //Debug.LogError("No se ha asignado ningún Material en el array.");
        }
    }

    public void Museo_2()
    {
        Renderer mRend = esfera.GetComponent<Renderer>();
        if (m_Materiales.Length > 0)
        {
            DetenerTodosLosAudiosExcepto(1);
            mRend.material = m_Materiales[1];
            // Detener el audio si ya está reproduciéndose
            if (m_Audio[1].isPlaying)
            {
                m_Audio[1].Stop();
            }
            else
            {
                // Reproducir el audio desde el principio
                m_Audio[1].Play();
            }
        }
        else
        {
            //Debug.LogError("No se ha asignado ningún Material en el array.");
        }
    }

    public void Museo_3()
    {
        Renderer mRend = esfera.GetComponent<Renderer>();
        if (m_Materiales.Length > 0)
        {
            DetenerTodosLosAudiosExcepto(2);
            mRend.material = m_Materiales[2];
            if (m_Audio[2].isPlaying)
            {
                m_Audio[2].Stop();
            }
            else
            {
                m_Audio[2].Play();
            }

        }
        else
        {
            //Debug.LogError("No se ha asignado ningún Material en el array.");
        }
    }

    public void Museo_4()
    {
        Renderer mRend = esfera.GetComponent<Renderer>();
        if (m_Materiales.Length > 0)
        {
            DetenerTodosLosAudiosExcepto(3);
            mRend.material = m_Materiales[3];
            if (m_Audio[3].isPlaying)
            {
                m_Audio[3].Stop();
            }
            else
            {
                m_Audio[3].Play();
            }
        }
        else
        {
            //Debug.LogError("No se ha asignado ningún Material en el array.");
        }
    }

    public void Museo_5()
    {
        Renderer mRend = esfera.GetComponent<Renderer>();
        if (m_Materiales.Length > 0)
        {
            DetenerTodosLosAudiosExcepto(4);
            mRend.material = m_Materiales[4];
            if (m_Audio[4].isPlaying)
            {
                m_Audio[4].Stop();
            }
            else
            {
                m_Audio[4].Play();
            }
        }
        else
        {
            //Debug.LogError("No se ha asignado ningún Material en el array.");
        }
    }

    public void Museo_6()
    {
        Renderer mRend = esfera.GetComponent<Renderer>();
        if (m_Materiales.Length > 0)
        {DetenerTodosLosAudiosExcepto(5);
            mRend.material = m_Materiales[5];
            if (m_Audio[5].isPlaying)
            {
                m_Audio[5].Stop();
            }
            else
            {
                m_Audio[5].Play();
            }
        }
        else
        {
            //Debug.LogError("No se ha asignado ningún Material en el array.");
        }
    }

    public void Museo_7()
    {
        Renderer mRend = esfera.GetComponent<Renderer>();
        if (m_Materiales.Length > 0)
        {
            DetenerTodosLosAudiosExcepto(6);
            mRend.material = m_Materiales[6];
            if (m_Audio[6].isPlaying)
            {
                m_Audio[6].Stop();
            }
            else
            {
                m_Audio[6].Play();
            }
        }
        else
        {
            //Debug.LogError("No se ha asignado ningún Material en el array.");
        }
    }

    public void Museo_8()
    {
        Renderer mRend = esfera.GetComponent<Renderer>();
        if (m_Materiales.Length > 0)
        {
            DetenerTodosLosAudiosExcepto(7);
            mRend.material = m_Materiales[7];
            if (m_Audio[7].isPlaying)
            {
                m_Audio[7].Stop();
            }
            else
            {
                m_Audio[7].Play();
            }

        }
        else
        {
            //Debug.LogError("No se ha asignado ningún Material en el array.");
        }
    }

    public void Refugio_1()
    {
        Renderer mRend = esfera.GetComponent<Renderer>();
        if (m_Materiales.Length > 0)
        {
            DetenerTodosLosAudiosExcepto(8);
            mRend.material = m_Materiales[8];
            if (m_Audio[8].isPlaying)
            {
                m_Audio[8].Stop();
            }
            else
            {
                m_Audio[8].Play();
            }

        }
        else
        {
            //Debug.LogError("No se ha asignado ningún Material en el array.");
        }
    }
    public void Refugio_2()
    {
        Renderer mRend = esfera.GetComponent<Renderer>();
        if (m_Materiales.Length > 0)
        {
            DetenerTodosLosAudiosExcepto(9);
            mRend.material = m_Materiales[9];
            if (m_Audio[9].isPlaying)
            {
                m_Audio[9].Stop();
            }
            else
            {
                m_Audio[9].Play();
            }

        }
        else
        {
            //Debug.LogError("No se ha asignado ningún Material en el array.");
        }
    }
    public void Refugio_3()
    {
        Renderer mRend = esfera.GetComponent<Renderer>();
        //Renderer pRend = puerta.GetComponent<Renderer>();
        if (m_Materiales.Length > 0)
        {
            DetenerTodosLosAudiosExcepto(10);
            mRend.material = m_Materiales[10];
            if (m_Audio[10].isPlaying)
            {
                m_Audio[10].Stop();
            }
            else
            {
                m_Audio[10].Play();
            }

        }
        else
        {
            //Debug.LogError("No se ha asignado ningún Material en el array.");
        }
    }
    public void Refugio_4()
    {
        Renderer mRend = esfera.GetComponent<Renderer>();
        if (m_Materiales.Length > 0)
        {
            DetenerTodosLosAudiosExcepto(11);
            mRend.material = m_Materiales[11];
            if (m_Audio[11].isPlaying)
            {
                m_Audio[11].Stop();
            }
            else
            {
                m_Audio[11].Play();
            }
        }
        else
        {
            //Debug.LogError("No se ha asignado ningún Material en el array.");
        }
    }
    public void Refugio_5()
    {
        Renderer mRend = esfera.GetComponent<Renderer>();
        if (m_Materiales.Length > 0)
        {
            DetenerTodosLosAudiosExcepto(12);
            mRend.material = m_Materiales[12];
            if (m_Audio[12].isPlaying)
            {
                m_Audio[12].Stop();
            }
            else
            {
                m_Audio[12].Play();
            }
        }
        else
        {
            //Debug.LogError("No se ha asignado ningún Material en el array.");
        }
    }

    public void Laguna_1()
    {
        Renderer mRend = esfera.GetComponent<Renderer>();
        if (m_Materiales.Length > 0)
        {
            DetenerTodosLosAudiosExcepto(13);
            mRend.material = m_Materiales[13];
            if (m_Audio[13].isPlaying)
            {
                m_Audio[13].Stop();
            }
            else
            {
                m_Audio[13].Play();
            }

        }
        else
        {
            //Debug.LogError("No se ha asignado ningún Material en el array.");
        }
    }

    // Método para detener todos los audios excepto el índice proporcionado
    private void DetenerTodosLosAudiosExcepto(int indice)
    {
        for (int i = 0; i < m_Audio.Length; i++)
        {
            if (i != indice && m_Audio[i].isPlaying)
            {
                m_Audio[i].Stop();
            }
        }
    }

}

