using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    #region REFERENCES
    Inventory inventory;
    AudioManager audioManager;
    #endregion

    #region VARIABLES
    [Header("ECONOMY")]
    [Space(5)]
    public int initialMoney;
    public TextMeshProUGUI initialMoneyText;

    [Header("ITEM INFO")]
    [Space(5)]
    public TextMeshProUGUI itemDataText;

    [Header("RECEIPT")]
    [Space(5)]
    public TextMeshProUGUI receiptText;
    public GameObject receiptObject;

    [Header("PAUSE")]
    [Space(5)]
    public GameObject pauseMenuObject;
    bool isPause;

    #endregion


    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Pay();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePauseMenu();
        }
    }

    void Pay()
    {
        int moneyToPay = 0;
        receiptText.text = "-- BOLETA --\n\n";

        for (int i = 0; i < inventory.itemInventory.Count; i++)
        {
            moneyToPay += inventory.itemInventory[i].itemName;
        }

        receiptText.text += "\n-- DINERO --\n\n";
        receiptText.text += "TOTAL: $" + 0 + "\n";
        receiptText.text += "PAGADO CON: $" + 0 + "\n";

        if (moneyToPay >= initialMoney)
        {
            receiptText.text += "VUELTO: $" + 0 + "\n\n";
            receiptText.text += "-- GRACIAS POR SU COMPRA --";
        }
        else
        {
            receiptText.text += "DINERO INSUFICIENTE\n\n";
            receiptText.text += "-- COMPRA CANCELADA --";
        }

        receiptObject.SetActive(true);
        Time.timeScale = 0;
    }

    void SetInitialMoney()
    {
        initialMoneyText.text = "Dinero inicial: $" + 0;
    }

    public void SetItemData(ItemData dataToDisplay)
    {
        itemDataText.text = dataToDisplay.itemPrice + ": $" + dataToDisplay.itemPrice;
    }

    public void ClearItemData()
    {
        itemDataText.text = "(-.-)";
    }

    void TogglePauseMenu()
    {
        isPause = !isPause;
        if (isPause == true)
        {
            Time.timeScale = 0;
            pauseMenuObject.SetActive(true);
        }
    }
}
