using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization.Settings;

public class LanguageSelector : MonoBehaviour
{
    public GameObject lenguagePopUp; // Referencia al objeto de la ventana flotante
    public Button languageButton; // Bot�n para abrir la ventana flotante
    public Button closeButton; // Bot�n para cerrar la ventana flotante
    public Button[] languageButtons; // Botones para seleccionar el idioma

    void Start()
    {
        // Oculta la ventana flotante al inicio
        lenguagePopUp.SetActive(false);

        // Asigna la funci�n para abrir la ventana flotante al bot�n de configuraci�n
        languageButton.onClick.AddListener(() => ShowLanguagePopup());

        // Asigna la funci�n para cerrar la ventana flotante al bot�n de cerrar
        closeButton.onClick.AddListener(() => CloseLanguagePopup());

        // Asigna las funciones correspondientes a los botones de idioma
        foreach (Button button in languageButtons)
        {
            button.onClick.AddListener(() => SelectLanguage(button));
        }
    }

    // Funci�n para mostrar la ventana flotante
    public void ShowLanguagePopup()
    {
        lenguagePopUp.SetActive(true);
    }

    // Funci�n para ocultar la ventana flotante
    public void CloseLanguagePopup()
    {
        lenguagePopUp.SetActive(false);
    }

    // Funci�n para seleccionar el idioma
    public void SelectLanguage(Button button)
    {
        string languageCode = button.name; // El nombre del bot�n se usa directamente como el c�digo de idioma
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.GetLocale(languageCode);
        CloseLanguagePopup(); // Cerrar la ventana flotante despu�s de seleccionar el idioma
    }

}
