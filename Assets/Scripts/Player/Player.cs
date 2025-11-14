using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance { get; private set; }

    public Animator animator;
    // Start is called before the first frame update

    public PlayerStats playerStats;
    public PLayerMovement playerMovement;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
