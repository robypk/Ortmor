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
    // Start is called before the first frame update
    void Start()
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
