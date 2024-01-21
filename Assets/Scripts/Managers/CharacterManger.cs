using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public enum Character
{
    NUQA,
    QUALUM,
    SUP,
    WAM
}
public class CharacterManger : MonoBehaviour
{
    public void characterSelection(Character character, bool isSlected)
    {

        if(isSlected)
        {
            DataContainer.Instance.SelectedCharacters.Add(character);
        }
        else
        {
            DataContainer.Instance.SelectedCharacters.Remove(character);
        }

    }

    public void onProcessedButtonClick()
    {
        DataContainer.Instance.SceneLoad(1);
    }


}
