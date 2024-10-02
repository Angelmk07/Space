using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyView : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI m_TextMeshProUGUI;
    private void OnEnable()
    {
        PlayerResources.BoughtEvent += Spend;
    }
    private void OnDisable()
    {
        PlayerResources.BoughtEvent -= Spend;
    }

    private void Spend(int value)
    {
        m_TextMeshProUGUI.text = $"You have {value}";
    }
}
