using UnityEngine;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour
{
    public GameObject ui;

    public Button upgradeButton;

    public Text upgradeCost;
    public Text sellAmount;

    private Node target;

    public void SetTarget(Node _target)
    {
        this.target = _target;

        transform.position = target.GetBuildPosition();

        upgradeCost.text = "$" + target.turretBlueprint.upgradeCost;

        sellAmount.text = "$" + target.turretBlueprint.GetSellAmount();

        ui.SetActive(true);
    }

    public void Hide()
    {
        ui.SetActive(false);
    }

    public void Upgrade()
    {
        target.UpgradeTurret();
        BuildManager.instance.DeselectNode(); 
    }

    public void Sell()
    {
        target.SellTurret();
        BuildManager.instance.DeselectNode();
    }
}