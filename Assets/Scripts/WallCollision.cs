using UnityEngine;

public class WallCollision : MonoBehaviour
{
    [SerializeField]
    private Material wallMaterial;

    private void Awake()
    {
    }

    void Start()
    {
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.LogError(collision.gameObject.tag);
        if(collision.gameObject.tag == "Box")
        {
            wallMaterial.color = Random.ColorHSV();
        }
    }
}
