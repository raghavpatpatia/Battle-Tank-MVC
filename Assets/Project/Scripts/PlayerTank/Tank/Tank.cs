using UnityEngine;

public class Tank : MonoBehaviour
{
    public TankType tankType;
    private static Tank instance;
    public static Tank Instance { get { return instance; } }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}