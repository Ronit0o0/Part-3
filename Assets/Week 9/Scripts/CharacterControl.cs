using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class CharacterControl : MonoBehaviour
{
    public TMPro.TextMeshProUGUI currentSelection;
    public TMP_Dropdown dropdown;
    public static CharacterControl Instance;
    public Villager[] villager = new Villager[3];

   
    private void Start()
    {
        Instance = this;
    }
    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        Instance.currentSelection.text = villager.ToString();
    }
    public void DropDownSelection(Int32 picked)
    {
        for (int i = 0; i < villager.Length; i++)
        {
            if (dropdown.options[picked].text == villager[i].name) SetSelectedVillager(villager[i]);
        }
    }

    //private void Update()
    //{
    //  if(SelectedVillager != null)
    //{
    //    currentSelection.text = SelectedVillager.GetType().ToString();
    // }
    //}
}
