using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoShare : MonoBehaviour
{


    [SerializeField] RawImage PreviewImage;
    [SerializeField] GameObject AfterSaveDialogue;
    Texture2D PhotoTaken;



    private void Start()
    {

        PhotoTaken = DataContainer.Instance.capturePhoto;
        float aspectRatio = (float)PhotoTaken.width / PhotoTaken.height;
        PreviewImage.rectTransform.sizeDelta = new Vector2(PreviewImage.rectTransform.sizeDelta.y * aspectRatio, PreviewImage.rectTransform.sizeDelta.y);
        PreviewImage.texture = PhotoTaken;
    }


    public void onSaveButtonClick()
    {
        string uniqueName = "Screenshot_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";
        NativeGallery.SaveImageToGallery(PhotoTaken, "OrtmorAR", uniqueName);
        AfterSaveDialogue.SetActive(true);
    }


    public void onHomeButtonClick()
    {
        DataContainer.Instance.SceneLoad(0);
    }
}
