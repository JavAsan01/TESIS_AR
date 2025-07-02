using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    //public Text buttonText;
    public Button button;
    public TMP_Text buttonText;

    private bool isPaused = false;

    void Start()
    {
        // Aseg�rate de que el bot�n tenga un listener asociado al m�todo TogglePlayPause
        if (button != null) // Verifica que el bot�n no sea nulo
        {
            button.onClick.AddListener(TogglePlayPause);
        }
        else
        {
            Debug.LogWarning("Button component is not assigned to AudioController.");
        }

        // Aseg�rate de que el texto del bot�n refleje el estado de reproducci�n
        buttonText.text = "Play";
    }
    void Update()
    {
        // Verifica si el audio no se est� reproduciendo y si el estado actual no coincide con el estado de pausa
        if (!audioSource.isPlaying && !isPaused)
        {
            buttonText.text = "Play"; // Si el audio no se est� reproduciendo y no est� en pausa, establece el texto del bot�n en "Play"
        }
    }

    public void TogglePlayPause()
    {
        Debug.Log("TogglePlayPause() called");
        if (isPaused)
        {
            PlayAudio();
        }
        else
        {
            PauseAudio();
        }
    }

    public void PlayAudio()
    {
        audioSource.Play();
        buttonText.text = "Pause";
        Debug.Log("Audio is now playing.");
        isPaused = false;
        UpdateButtonText();
    }

    public void PauseAudio()
    {
        audioSource.Pause();
        buttonText.text = "Play";
        Debug.Log("Audio is now paused.");
        isPaused = true;
        UpdateButtonText();
    }

    void UpdateButtonText()
    {
        buttonText.text = isPaused ? "Play" : "Pause"; // Actualiza el texto del bot�n seg�n el estado de pausa
    }
}