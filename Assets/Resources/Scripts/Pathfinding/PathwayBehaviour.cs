using UnityEngine;
using PathCreation;
using System.Collections;

public class PathwayBehaviour : MonoBehaviour
{
    public PathCreator pathC;
    public bool isDeleting;

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
        yield return new WaitForSeconds(2);
        isDeleting = false;
    }
}
