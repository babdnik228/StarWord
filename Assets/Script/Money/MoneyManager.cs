using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    [SerializeField] private GameObject panel_Money;
    [SerializeField] private bool panel_active;
    public void PanelMoneyClick()
    {
        if (panel_active == false)
        {
            panel_active = true;
        }
        else if (panel_active == true)
        {
            panel_active = false;
        }

        if (panel_active == true)
        {
            panel_Money.SetActive(true);
        }
        if (panel_active == false)
        {
            panel_Money.SetActive(false);
        }
    }
}
