using UnityEngine;

public class Item : MonoBehaviour
{
    public bool hasSomethingOnTop = false;

    public ItemConfig config;

    [SerializeField] private float topThreshold = 0.1f;

    private void Start()
    {
        gameObject.layer = LayerMask.NameToLayer("Grabbable");
    }


    private void OnCollisionStay(Collision collision)
    {
        hasSomethingOnTop = false;
        foreach (ContactPoint contact in collision.contacts)
        {
            if (Vector3.Dot(contact.normal, Vector3.down) > topThreshold)
            {
                hasSomethingOnTop = true;
                break;
            }
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        hasSomethingOnTop = false;
    }
}
