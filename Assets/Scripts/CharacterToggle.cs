using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterToggle : MonoBehaviour
{
    [SerializeField] Character Character;
    [SerializeField] Toggle Toggle;
    CharacterManger characterManger;

    private void Start()
    {
        characterManger = GetComponentInParent<CharacterManger>();
        Toggle.onValueChanged.AddListener(CharacterSelector);

    }




    public void CharacterSelector(bool isSelected)
    {
       characterManger.characterSelection(Character, isSelected);
    }
}
