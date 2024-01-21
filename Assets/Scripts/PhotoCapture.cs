using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Android;
using NativeGalleryNamespace;
using UnityEngine.UI;
using TMPro;
using System;

public class PhotoCapture : MonoBehaviour
{

    [SerializeField] TMP_Text Timertext;
    [SerializeField] CharacterSpawner characterSpawner;
    [SerializeField] GameObject CaptureButton;

    public void CaptureScreenshot()
    {
        Timertext.transform.parent.gameObject.SetActive(true);
        StartCoroutine(CountdownTimer(10));
    }

    IEnumerator CountdownTimer(int seconds)
    {
        characterSpawner.SpawnCharacter();
        for (int i = seconds; i > -1; i--)
        {
            Timertext.text = i.ToString("00");
            yield return new WaitForSeconds(1f);
        }
        Timertext.transform.parent.gameObject.SetActive(false);
        StartCoroutine(TakeScreenshotAndSave());    
    }

    IEnumerator TakeScreenshotAndSave()
    {
        CaptureButton.SetActive(false);
        yield return new WaitForEndOfFrame();
        Texture2D screenshotTexture = ScreenCapture.CaptureScreenshotAsTexture();
        DataContainer.Instance.capturePhoto = screenshotTexture;
        DataContainer.Instance.SceneLoad(2);
        
    }

}
