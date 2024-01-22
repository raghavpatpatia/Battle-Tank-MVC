using UnityEngine; 

public class TankColor
{
    private TankView tankView;

    public TankColor(TankView tankView) => this.tankView = tankView;

    public void ChangeColor(Material material)
    {
        foreach (MeshRenderer tankPart in tankView.tankParts)
        {
            tankPart.material = material;
        }
    }
}