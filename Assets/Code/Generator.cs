using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] Transform itemsParent;
    [SerializeField] Transform launchPoint;

    [SerializeField] Vector3 launchVector;
    [SerializeField] float launchForce;

    [Header("Listener Events")]
    [SerializeField] EventChannel GeneratorClickedEvent;

    private int itemIndex = 0;

    private void OnEnable()
    {
        itemIndex = 0;

        GeneratorClickedEvent.OnEventTriggered += GenerateItem;
    }

    private void OnDisable()
    {
        GeneratorClickedEvent.OnEventTriggered -= GenerateItem;
    }

    private void GenerateItem()
    {
        if (itemIndex < LevelManager.instance.currentLevel.items.Length)
        {
            Item itemToSpawn = Instantiate(LevelManager.instance.currentLevel.items[itemIndex], itemsParent);
            Rigidbody itemBody = itemToSpawn.GetComponent<Rigidbody>();
            
            itemToSpawn.transform.position = launchPoint.position;
            itemBody.AddForce((transform.forward * launchVector.z + transform.up * launchVector.y) * launchForce);
            
            itemIndex++;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(launchPoint.position, launchPoint.position + transform.forward * launchVector.z + transform.up * launchVector.y);
    }
}
