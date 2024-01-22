using UnityEngine;

public class BulletModel
{
    public BulletController bulletController { get; private set; }
    public float bulletSpeed { get; private set; }
    public Gradient particleColor { get; private set; }
    public void SetBulletController(BulletController bulletController)
    {
        this.bulletController = bulletController;
    }
    public BulletModel(BulletScriptableObject bulletSO)
    {
        this.bulletSpeed = bulletSO.bulletSpeed;
        this.particleColor = bulletSO.particleColor;
    }
}