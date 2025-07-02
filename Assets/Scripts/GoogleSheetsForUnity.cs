using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class GoogleSheetsForUnity : MonoBehaviour
{
    [Header("GoogleSheets Information")]
    [SerializeField] private string spreadSheetID;
    [SerializeField] private string sheetID;

    private string serviceAccountEmail = "googlesheetsunity@latour-412305.iam.gserviceaccount.com";
    private string certificateName = "latour-412305-faa2972a6c68.p12";
    private string certificatePath;

    private static SheetsService googleSheetsService;

    [Serializable]
    public class Row
    {
        public List<string> cellData = new List<string>();
    }

    [Serializable]
    public class RowList
    {
        public List<Row> rows = new List<Row>();
    }

    public RowList DataFromGoogleSheets = new RowList();

    [Header("UI")]
    public Text displayText;

    void Start()
    {
        certificatePath = Application.dataPath + "/StreamingAssets/" + certificateName;

        try
        {
            var certificate = new X509Certificate2(certificatePath, "notasecret", X509KeyStorageFlags.Exportable);

            ServiceAccountCredential credential = new ServiceAccountCredential(
                new ServiceAccountCredential.Initializer(serviceAccountEmail)
                {
                    Scopes = new[] { SheetsService.Scope.Spreadsheets }
                }.FromCertificate(certificate));

            googleSheetsService = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "GoogleSheets API for Unity"
            });

            ReadAllData(); // Lee todos los datos al iniciar (puedes modificar esto según tu lógica)
        }
        catch (Exception e)
        {
            Debug.LogError("Error during initialization: " + e.Message);
        }
    }

    public void ReadAllData()
    {
        string range = sheetID; // Lee todo el rango

        try
        {
            var request = googleSheetsService.Spreadsheets.Values.Get(spreadSheetID, range);
            var response = request.Execute();
            var values = response.Values;

            if (values != null && values.Any())
            {
                foreach (var row in values)
                {
                    Row newRow = new Row();
                    DataFromGoogleSheets.rows.Add(newRow);

                    foreach (var value in row)
                    {
                        newRow.cellData.Add(value.ToString());
                        Debug.Log(value.ToString());
                    }
                }

                // Optional: Display the data in a UI Text component
                if (displayText != null)
                {
                    displayText.text = FormatDataForDisplay();
                }
            }
            else
            {
                Debug.LogWarning("No data found in the specified range.");
            }
        }
        catch (Exception e)
        {
            Debug.LogError("Error reading data: " + e.Message);
        }
    }

    // Optional: Format data for display in UI
    private string FormatDataForDisplay()
    {
        string formattedData = "Google Sheets Data:\n";

        foreach (var row in DataFromGoogleSheets.rows)
        {
            formattedData += string.Join(", ", row.cellData) + "\n";
        }

        return formattedData;
    }
}
