using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Состояния игрока
    public enum States
    {
        InGame,
        OnPause,
        Died
    }
    [SerializeField] private States state = States.OnPause;
    public States PlayerState { get => state; }
    
    // Данные для управления движением
    [SerializeField] private float jumpForce = 10f;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && state != States.Died)
        {
            if(state == States.OnPause)
            {
                state = States.InGame;
                rb.simulated = true;
            }
            rb.velocity = Vector2.up * jumpForce; 
        }
    }

    public void KillPlayer()
    {
        if(state != States.Died) state = States.Died;
    }
}
