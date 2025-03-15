using UnityEngine;

public class BridgeTrigger : MonoBehaviour
{
    Animator bridgeAnim;

    void Start()
    {
        bridgeAnim = this.transform.parent.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        bridgeAnim.SetBool("enableExpand", true);
    }

}
