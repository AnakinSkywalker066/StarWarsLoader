using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using StarWarsLoader;

public class LegoGuy : ModTower
{
    public override TowerSet TowerSet => TowerSet.Primary;

    public override string BaseTower => "DartMonkey";

    public override int Cost => 0;

    public override int TopPathUpgrades => 0;

    public override int MiddlePathUpgrades => 0;

    public override int BottomPathUpgrades => 0;

    public override void ModifyBaseTowerModel(TowerModel towerModel)
    {
        towerModel.ApplyDisplay<LEGODisplay>();
        towerModel.displayScale = 10;
    }
}
