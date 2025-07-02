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
        // Asegúrate de que el botón tenga un listener asociado al método TogglePlayPause
        if (button != null) // Verifica que el botón no sea nulo
        {
            button.onClick.AddListener(TogglePlayPause);
        }
        else
        {
            Debug.LogWarning("Button component is not assigned to AudioController.");
        }

        // Asegúrate de que el texto del botón refleje el estado de reproducción
        buttonText.text = "Play";
    }
    void Update()
    {
        // Verifica si el audio no se está reproduciendo y si el estado actual no coincide con el estado de pausa
        if (!audioSource.isPlaying && !isPaused)
        {
            buttonText.text = "Play"; // Si el audio no se está reproduciendo y no está en pausa, establece el texto del botón en "Play"
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
        buttonText.text = isPaused ? "Play" : "Pause"; // Actualiza el texto del botón según el estado de pausa
    }
}