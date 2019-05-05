using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint mageTurret;
    public TurretBlueprint cannonTurret;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectMageTurret()
    {
        Debug.Log("Mage Turret Purchased");
        buildManager.SelectTurretToBuild(mageTurret);
    }

    public void SelectCannonTurret()
    {
        Debug.Log("Cannon Turret Purchased");
        buildManager.SelectTurretToBuild(cannonTurret);
    }
}
