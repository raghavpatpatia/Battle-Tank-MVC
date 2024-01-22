using UnityEngine;

public class TankModel
{
    public TankController tankController {get; private set;}
    public float tankSpeed { get; private set;}
    public float rotationSpeed { get; private set;}
    public TankType tankType { get; private set;}
    public Material tankMaterial { get; private set;}
    public BulletScriptableObject bullet { get; private set; }
    public void SetTankController(TankController tankController) => this.tankController = tankController;
    public TankModel(TankScriptableObject tankScriptableObject)
    {
        this.tankSpeed = tankScriptableObject.tankSpeed;
        this.rotationSpeed = tankScriptableObject.rotationSpeed;
        this.tankMaterial = tankScriptableObject.tankMaterial;
        this.tankType = tankScriptableObject.tankType;
        this.bullet = tankScriptableObject.bullet;
    }
}
