using System.Drawing;
using UnityEngine;

public class BulletController
{
    public BulletModel bulletModel { get; private set; }
    public BulletView bulletView { get; private set; }

    public BulletController(BulletScriptableObject bulletSO, Transform bulletSpawnPoint)
    {
        bulletModel = new BulletModel(bulletSO);
        bulletModel.SetBulletController(this);

        bulletView = GameObject.Instantiate<BulletView>(bulletSO.bulletview, bulletSpawnPoint);
        bulletView.SetBulletController(this);
        var colorOverLifetime = bulletView.bulletParticleSystem.colorOverLifetime;
        colorOverLifetime.color = bulletModel.particleColor;
    }

    public void ShootBullet()
    {
        if (bulletView.rb != null)
        {
            bulletView.transform.parent = null;
            bulletView.rb.AddForce(bulletView.rb.transform.forward * bulletModel.bulletSpeed, ForceMode.Impulse);
        }
    }

    public void OnCollision(Collision collision)
    {
        GameObject.Destroy(bulletView.gameObject);
    }
}