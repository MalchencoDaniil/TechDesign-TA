using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class Interact : MonoBehaviour, IInteractable
{
    private bool _interact = true;

    [SerializeField]
    private float _waitTime = 1;

    [SerializeField]
    private UnityEvent _interactionEvent;

    public bool CanInteract() => _interact;

    public async void ObjectInteract()
    {
        _interactionEvent.Invoke();
        await InteractedWait();
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && CanInteract())
        {
            ObjectInteract();
        }
    }

    private async UniTask InteractedWait()
    {
        _interact = false;

        await UniTask.WaitForSeconds(_waitTime);

        _interact = true;
    }
}