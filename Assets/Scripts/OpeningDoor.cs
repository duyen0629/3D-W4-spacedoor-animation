using UnityEngine;

public class OpeningDoor : MonoBehaviour
{
    Animator doorAnim;

    void Start()
    {
        doorAnim = this.transform.parent.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        doorAnim.SetBool("isOpen", true);
    }

    void OnTriggerExit(Collider other)
    {
        doorAnim.SetBool("isOpen", false);
    }
}
