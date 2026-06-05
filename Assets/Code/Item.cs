using UnityEngine;

public class Item : MonoBehaviour
{
    [Header("Broadcast Events")]
    [SerializeField] private EventChannel SampleEvent1;

    [Header("Listener Events")]
    [SerializeField] private EventChannel SampleEvent2;

    private void OnEnable()
    {
        SampleEvent2.OnEventTriggered += Foo;
    }

    private void OnDisable()
    {
        SampleEvent2.OnEventTriggered -= Foo;
    }

    private void Foo()
    {

    }

    private void Start()
    {
        SampleEvent1.RaiseEvent();
    }

}
