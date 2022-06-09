using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;//for DateTime used in SnapScreenshot()
using System.IO;//for Path class

public class NewCameraPhysical : MonoBehaviour
{
    [SerializeField] private RenderTexture PadTexture;
    [SerializeField] private string Name;

    void Update()
    {
        if (Input.GetButtonDown("UpTrigger"))
        {
            Debug.Log("UPDATE!");
            SnapScreenshot();
        }
    }

    void SnapScreenshot()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            /*
            DateTime CurrentTime = DateTime.Now;
            string Date_str = CurrentTime.ToString("dd/MM/yyyy HH:mm:ss");
            Date_str = Date_str.Replace('.', '-');
            Date_str = Date_str.Replace(' ', '_');
            Date_str = Date_str.Replace(':', '/'); //characters not confusing in path
            */
            RenderTexture.active = PadTexture;
            Texture2D RenderedImage = new Texture2D(PadTexture.width, PadTexture.height, TextureFormat.RGBA32, false);
            Rect rect = new Rect(0, 0, PadTexture.width, PadTexture.height);
            RenderedImage.ReadPixels(rect, 0, 0);
            RenderTexture.active = null; //avoiding memory leak
            byte[] byteArray = RenderedImage.EncodeToPNG();

            /*
            var JavaClass = new AndroidJavaClass("android.os.Environment");
            string DCIMpath = JavaClass.CallStatic<AndroidJavaObject>("getExternalStoragePublicDirectory", JavaClass.GetStatic<string>("DIRECTORY_DCIM")).Call<string>("getAbsolutePath");
            string path = Path.Combine(DCIMpath, Name + ".png");
            */


            string path = Path.Combine(Application.persistentDataPath, Name + ".png");
            //string path = Path.Combine(Application.persistentDataPath, Name + "_" + Date_str + ".png");
            //string path = Path.Combine(Application.persistentDataPath, "cus.png");
            System.IO.File.WriteAllBytes(path, byteArray);
            Debug.Log("ANDROID!");
        }
        Debug.Log("FUNKCJA!");
    }
}
