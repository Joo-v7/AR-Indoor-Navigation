using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class SetNavigationTarget : MonoBehaviour
{
    [SerializeField]
    private List<Target> navigationTargetObjects = new List<Target>();
    [SerializeField]
    private Slider navigationYOffset;

    private NavMeshPath path; // current calculated path
    private LineRenderer line; // linerenderer to display path
    private Vector3 targetPosition = Vector3.zero; // current target position

    private int currentFloor = 1;

    private bool lineToggle = false;

    private void Start()
    {
        path = new NavMeshPath();
        line = transform.GetComponent<LineRenderer>();
        line.enabled = lineToggle;
    }


    private void Update()
    {
        if (lineToggle && targetPosition != Vector3.zero)
        {
            NavMesh.CalculatePath(transform.position, targetPosition, NavMesh.AllAreas, path);
            line.positionCount = path.corners.Length;
            line.SetPositions(path.corners);
            Vector3[] calculatedPathAndOffset = AddLineOffset();
            line.SetPositions(calculatedPathAndOffset);

        }
    }
    public void SetCurrentNavigationTarget(int selectedValue)
    {
        targetPosition = Vector3.zero;
        string selectedText = NavigationData.instance.DestinationDropDown.options[selectedValue].text;
        Target currentTarget = navigationTargetObjects.Find(x => x.Name.ToLower().Equals(selectedText.ToLower()));
        if (currentTarget != null)
        {

            if (!line.enabled)
            {
                ToggleVisibility();
            }

            targetPosition = currentTarget.PositionObject.transform.position;
        }
    }

    public void ToggleVisibility()
    {
        lineToggle = !lineToggle;
        line.enabled = lineToggle;
    }

    public void ChangeActiveFloor()
    {
        currentFloor = (int)NavigationData.instance.Floor;
        Debug.Log(currentFloor);
        //SetNavigationTargetDropDownOptions(currentFloor);
    }

    private Vector3[] AddLineOffset()
    {
        if (navigationYOffset.value == 0)
        {
            return path.corners;
        }

        Vector3[] calculatedLine = new Vector3[path.corners.Length];
        for (int i = 0; i < path.corners.Length; i++)
        {
            calculatedLine[i] = path.corners[i] + new Vector3(0, navigationYOffset.value, 0);
        }
        return calculatedLine;
    }

   
}