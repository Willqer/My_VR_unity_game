using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;//for Path.Combine
using System;//for DateTime used in SnapScreenshot()

public class PhysicalCamera : MonoBehaviour
{
    //==========================
    [SerializeField] private RenderTexture PadTexture;
    [SerializeField] private string Name;
    //==========================
    private ControlsMap mapping;
    //==========================
    private void OnEnable()
    {
        mapping.Enable();
    }
    private void OnDisable()
    {
        mapping.Disable();
    }
    //==========================
    private void Awake()
    {
        mapping = new ControlsMap();
        mapping.PhysicalCamera.Screenshot.performed += context => SnapScreenshot();
    }
    void update()
    {
        if (Input.GetButtonDown("UpTrigger"))
        {
            Debug.Log("UPDATE!");
            //StartCoroutine(SnapScreenshotCR());
            SnapScreenshot();
        }
    }
    //==========================

    void SnapScreenshot()
    {
        ///*
        DateTime CurrentTime = DateTime.Now;
        string Date_str = CurrentTime.ToString("dd/MM/yyyy HH:mm:ss");
        Date_str = Date_str.Replace('.', '-');
        Date_str = Date_str.Replace(' ', '_');
        Date_str = Date_str.Replace(':', '-'); //characters not confusing in path

        RenderTexture.active = PadTexture;
        Texture2D RenderedImage = new Texture2D(PadTexture.width, PadTexture.height, TextureFormat.RGBA32, false);
        Rect rect = new Rect(0, 0, PadTexture.width, PadTexture.height);
        RenderedImage.ReadPixels(rect, 0, 0);
        RenderTexture.active = null; //avoiding memory leak
        byte[] byteArray = RenderedImage.EncodeToJPG();
        //*/
        string path;
        if (Application.platform != RuntimePlatform.Android)
        {
            /*
            DateTime CurrentTime = DateTime.Now;
            string Date_str = CurrentTime.ToString("dd/MM/yyyy HH:mm:ss");
            Date_str = Date_str.Replace('.', '-');
            Date_str = Date_str.Replace(' ', '_');
            Date_str = Date_str.Replace(':', '-'); //characters not confusing in path

            RenderTexture.active = PadTexture;
            Texture2D RenderedImage = new Texture2D(PadTexture.width, PadTexture.height, TextureFormat.RGBA32, false);
            Rect rect = new Rect(0, 0, PadTexture.width, PadTexture.height);
            RenderedImage.ReadPixels(rect, 0, 0);
            RenderTexture.active = null; //avoiding memory leak

            byte[] byteArray = RenderedImage.EncodeToPNG();
            */

            path = "C:/Users/wojte/Desktop/" + Name + "_" + Date_str + ".jpg"; //Windows
            //System.IO.File.WriteAllBytes(path, byteArray);
        }
        else
        {

            /*
            RenderTexture.active = PadTexture;
            Texture2D RenderedImage = new Texture2D(PadTexture.width, PadTexture.height, TextureFormat.RGBA32, false);
            Rect rect = new Rect(0, 0, PadTexture.width, PadTexture.height);
            RenderedImage.ReadPixels(rect, 0, 0);
            RenderTexture.active = null; //avoiding memory leak

            byte[] byteArray = RenderedImage.EncodeToPNG();

            string path = Path.Combine(Application.persistentDataPath, Name + ".png"); //Android
            //(Path.DirectorySeparatorChar zamiast "/")
            System.IO.File.WriteAllBytes(path, byteArray);
            */


            ///*
            //var JavaClass = new AndroidJavaClass("android.os.Environment");
            //string DCIMpath = JavaClass.CallStatic<AndroidJavaObject>("getExternalStoragePublicDirectory", JavaClass.GetStatic<string>("DIRECTORY_DCIM")).Call<string>("getAbsolutePath");
            //string path = Path.Combine(DCIMpath, Name + "_" + Date_str + ".png"); //Android



            //path = Application.persistentDataPath + "/" + Name + "_" + Date_str + ".png"; //Android
            path = Path.Combine(Application.persistentDataPath, Name + "_" + Date_str + ".png"); //Android
            //path = Path.Combine("cus.jpg"); //Android
            //System.IO.File.WriteAllBytes(path, byteArray);

            //*/
        }
        System.IO.File.WriteAllBytes(path, byteArray);
    }
    //==========================
    private IEnumerator SnapScreenshotCR()
    {
        yield return new WaitForEndOfFrame();
        DateTime CurrentTime = DateTime.Now;
        string Date_str = CurrentTime.ToString("dd/MM/yyyy HH:mm:ss");
        Date_str = Date_str.Replace('.', '-');
        Date_str = Date_str.Replace(' ', '_');
        Date_str = Date_str.Replace(':', '-'); //characters not confusing in path

        RenderTexture.active = PadTexture;
        Texture2D RenderedImage = new Texture2D(PadTexture.width, PadTexture.height, TextureFormat.RGBA32, false);
        Rect rect = new Rect(0, 0, PadTexture.width, PadTexture.height);
        RenderedImage.ReadPixels(rect, 0, 0);
        RenderTexture.active = null; //avoiding memory leak
        byte[] byteArray = RenderedImage.EncodeToJPG();

        //string path = Path.Combine(Application.persistentDataPath, Name + "_" + Date_str + ".png");
        string path = Path.Combine(Application.persistentDataPath, "name.png");
        Debug.Log("ANDROIDcoROUTINE!");
        System.IO.File.WriteAllBytes(path, byteArray);
        yield return null;
    }


}
