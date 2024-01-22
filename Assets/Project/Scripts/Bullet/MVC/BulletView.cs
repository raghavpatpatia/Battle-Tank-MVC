using UnityEngine;

public class BulletView : MonoBehaviour
{
    public BulletController bulletController { get; private set; }
    [SerializeField] public Rigidbody rb;
    [SerializeField] public ParticleSystem bulletParticleSystem;
    private void Start()
    {
        bulletController.ShootBullet();
    }
    public void SetBulletController(BulletController bulletController)
    {
        this.bulletController = bulletController;
    }
    private void OnCollisionEnter(Collision collision)
    {
        bulletController.OnCollision(collision);
    }
}