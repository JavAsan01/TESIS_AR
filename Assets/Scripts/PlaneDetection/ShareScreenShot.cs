using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ShareScreenShot : MonoBehaviour
{
    //Descativar la UI
    [SerializeField] private GameObject mainMenuCanvas;
    //Descativar la nube de puntos
    private ARPointCloudManager aRPointCloudManager;
    void Start()
    {
        aRPointCloudManager = FindAnyObjectByType<ARPointCloudManager>();
    }


    public void TakeScreenShot()
    {
        TurnOffARContents();
        StartCoroutine(TakeScreenshotAndShare());
    }
    private void TurnOffARContents() 
    {
        var points = aRPointCloudManager.trackables;
        foreach (var point in points)
        {
            point.gameObject.SetActive(!gameObject.activeSelf);
        }
        mainMenuCanvas.SetActive(!mainMenuCanvas.activeSelf);        
    }
    private IEnumerator TakeScreenshotAndShare()
    {
        yield return new WaitForEndOfFrame();

        Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        ss.Apply();
        //hora
        string screenShotTime = System.DateTime.Now.ToString("HH-mm-ss");
        string filePath = Path.Combine(Application.temporaryCachePath, "Photo"+screenShotTime+".png");
        File.WriteAllBytes(filePath, ss.EncodeToPNG());

        // To avoid memory leaks
        Destroy(ss);

        new NativeShare().AddFile(filePath)

            //compartir mensaje con la foto
            .SetTitle("LATOUR")
            .SetSubject("Subject goes here").SetText("Foto tomada desde el Parque Nacional Cotopaxi") //.SetUrl("https://github.com/yasirkula/UnityNativeShare") link a compartir
            .SetCallback((result, shareTarget) => Debug.Log("Share result: " + result + ", selected app: " + shareTarget))
            .Share();
        TurnOffARContents();
        // Share on WhatsApp only, if installed (Android only)
        //if( NativeShare.TargetExists( "com.whatsapp" ) )
        //	new NativeShare().AddFile( filePath ).AddTarget( "com.whatsapp" ).Share();
    }
}
