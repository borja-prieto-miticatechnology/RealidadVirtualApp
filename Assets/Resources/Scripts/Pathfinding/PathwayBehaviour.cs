using UnityEngine;
using PathCreation;
using PathCreation.Examples;
using System.Collections;
using System.Collections.Generic;

public class PathwayBehaviour : MonoBehaviour
{
    PathCreator pathC;
    RoadMeshCreator road;

    public bool isDeleting;
    public float waitTime;

    public Transform pointsHolder;

    Stack<Vector3> waypointsPoisition;
    Stack<Quaternion> waypointsRotation;

    private void Start()
    {
        road = FindObjectOfType<RoadMeshCreator>();

        pathC = FindObjectOfType<PathCreator>();
        waypointsPoisition = new Stack<Vector3>();
        waypointsRotation = new Stack<Quaternion>();

        for(int i = pointsHolder.childCount - 1; i >= 0; i--)
        {
            waypointsPoisition.Push(pointsHolder.GetChild(i).transform.position);
             waypointsRotation.Push(pointsHolder.GetChild(i).transform.rotation);
        }

        GoToNextPoint(waypointsPoisition.Pop(), waypointsRotation.Pop());

        road.TriggerUpdate();
    }

    private void OnTriggerExit(Collider other)
    {

        if (!isDeleting)
        {
            isDeleting = true;
            pathC.bezierPath.DeleteSegment(0);
            //StartCoroutine(DeleteSegment());
        }
    }

    IEnumerator DeleteSegment()
    {
        print("asd");
        pathC.bezierPath.DeleteSegment(0);
        road.TriggerUpdate();
        yield return new WaitForSeconds(waitTime);
        isDeleting = false;
        if(waypointsPoisition.Count > 0)
        {
            GoToNextPoint(waypointsPoisition.Pop(),waypointsRotation.Pop());
        }
        road.TriggerUpdate();
    }

    void GoToNextPoint(Vector3 nextPoint, Quaternion nextPointRotation)
    {
        this.transform.position = nextPoint;
        this.transform.rotation = nextPointRotation;
    }
}
