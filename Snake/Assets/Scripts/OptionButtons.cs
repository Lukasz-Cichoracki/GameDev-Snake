using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionButtons : MonoBehaviour
{
    public GameObject menu;

    public TMP_Dropdown tD;

    public SO_DifficultySettings sDS;


    private void Start()
    {
        tD.value = sDS.Difficulty-1;
    }
    public void Back()
    {
        this.gameObject.SetActive(false);
        menu.SetActive(true);
    }

    public void DropdownOutput(int value)
    {
        sDS.Difficulty = value;
    }
}
