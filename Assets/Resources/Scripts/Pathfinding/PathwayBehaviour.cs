using UnityEngine;
using PathCreation;
using System.Collections;

public class PathwayBehaviour : MonoBehaviour
{
    public PathCreator pathC;
    public bool isDeleting;
    public float waitTime;

    private void OnTriggerExit(Collider other)
    {

        if (!isDeleting)
        {
            isDeleting = true;
            StartCoroutine(DeleteSegment());
        }
    }

    IEnumerator DeleteSegment()
    {
        pathC.bezierPath.DeleteSegment(0);
        yield return new WaitForSeconds(waitTime);
        isDeleting = false;
    }
}
