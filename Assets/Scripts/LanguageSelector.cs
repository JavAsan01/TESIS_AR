using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization.Settings;

public class LanguageSelector : MonoBehaviour
{
    public GameObject lenguagePopUp; // Referencia al objeto de la ventana flotante
    public Button languageButton; // Botón para abrir la ventana flotante
    public Button closeButton; // Botón para cerrar la ventana flotante
    public Button[] languageButtons; // Botones para seleccionar el idioma

    void Start()
    {
        // Oculta la ventana flotante al inicio
        lenguagePopUp.SetActive(false);

        // Asigna la función para abrir la ventana flotante al botón de configuración
        languageButton.onClick.AddListener(() => ShowLanguagePopup());

        // Asigna la función para cerrar la ventana flotante al botón de cerrar
        closeButton.onClick.AddListener(() => CloseLanguagePopup());

        // Asigna las funciones correspondientes a los botones de idioma
        foreach (Button button in languageButtons)
        {
            button.onClick.AddListener(() => SelectLanguage(button));
        }
    }

    // Función para mostrar la ventana flotante
    public void ShowLanguagePopup()
    {
        lenguagePopUp.SetActive(true);
    }

    // Función para ocultar la ventana flotante
    public void CloseLanguagePopup()
    {
        lenguagePopUp.SetActive(false);
    }

    // Función para seleccionar el idioma
    public void SelectLanguage(Button button)
    {
        string languageCode = button.name; // El nombre del botón se usa directamente como el código de idioma
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.GetLocale(languageCode);
        CloseLanguagePopup(); // Cerrar la ventana flotante después de seleccionar el idioma
    }

}
