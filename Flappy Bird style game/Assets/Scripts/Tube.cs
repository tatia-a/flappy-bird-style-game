using UnityEngine;

public class Tube : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float destroyDelay = 2f;
    private void Start()
    {
        Destroy(gameObject, destroyDelay);
    }
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
