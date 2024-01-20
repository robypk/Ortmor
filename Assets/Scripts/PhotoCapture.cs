using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Android;
using NativeGalleryNamespace;
using UnityEngine.UI;

public class PhotoCapture : MonoBehaviour
{

    [SerializeField] RawImage image;
    public IEnumerator TakeScreenshotAndSave()
    {
        yield return new WaitForEndOfFrame();
        Texture2D screenshot = ScreenCapture.CaptureScreenshotAsTexture();
        image.texture = screenshot;
        image.gameObject.SetActive(true);
        //NativeGallery.SaveImageToGallery(screenshot, "OrtmorSelfies", "Screenshot.png");
    }


    // Example: Call this method to take a screenshot and save it to the gallery
    public void CaptureScreenshot()
    {
        StartCoroutine(TakeScreenshotAndSave());
    }
}
