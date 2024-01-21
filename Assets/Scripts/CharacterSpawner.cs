using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{


    [SerializeField] GameObject NUQA;
    [SerializeField] GameObject QUALUM;
    [SerializeField] GameObject SUP;
    [SerializeField] GameObject WAM;

    private void Start()
    {

        NUQA.SetActive(false);
        QUALUM.SetActive(false);
        SUP.SetActive(false);
        WAM.SetActive(false);
    }
    public void SpawnCharacter()
    {
        foreach (Character item in DataContainer.Instance.SelectedCharacters)
        {
            switch (item)
            {
                case Character.NUQA:
                    NUQA.SetActive(true);
                    break;
                case Character.QUALUM:
                    QUALUM.SetActive(true);
                    break;
                case Character.SUP:
                    SUP.SetActive(true);
                    break;
                case Character.WAM:
                    WAM.SetActive(true);
                    break;
            }
        }
    }
}
