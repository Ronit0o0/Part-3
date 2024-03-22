using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class building : MonoBehaviour
{
   
    public GameObject building1;
    public GameObject building2;
    public GameObject building3;
    float scaleTime = 1f;

    private void Start()
    {
        StartCoroutine(ScaleBuilding());
    }

    IEnumerator ScaleBuilding()
    {
        float timeScaleup = 0;

        GameObject building = Instantiate(building1);

        while (timeScaleup < scaleTime)
        {
            timeScaleup += Time.deltaTime;

            building.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, timeScaleup/scaleTime);

            yield return null;

        }

        timeScaleup = 0;

        building = Instantiate(building2);

        while (timeScaleup < scaleTime)
        {
            timeScaleup += Time.deltaTime;

            building.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, timeScaleup / scaleTime);

            yield return null;

        }

        timeScaleup = 0;

        building = Instantiate(building3);

        while (timeScaleup < scaleTime)
        {
            timeScaleup += Time.deltaTime;

            building.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, timeScaleup / scaleTime);

            yield return null;

        }


    }

    private void Update()
    {
        
    }
}
