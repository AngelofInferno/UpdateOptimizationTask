using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagsBenchmark : MonoBehaviour
{
    public int testsCount = 100000;

    public int a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            DirectCompare();
            ReferenceCompare();
            
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            
            DestroyImmediate(go);
            Debug.Log(go);
        }
    }

    private void TagsCompareWithEqual()
    {
        for (int i = 0; i < testsCount; i++)
        {
            if (gameObject.tag == "Player")
            {
                a++;
            }
        }
    }

    private void TagsCompareWithCompareTags()
    {
        for (int i = 0; i < testsCount; i++)
        {
            if (gameObject.CompareTag("Player"))
            {
                a++;
            }
        }
    }

    private void DirectCompare()
    {
        for (int i = 0; i < testsCount; i++)
        {
            if (gameObject != null)
            {
                a++;
            }
        }
    }

    private void ReferenceCompare()
    {
        for (int i = 0; i < testsCount; i++)
        {
            if (!ReferenceEquals(gameObject, null))
            {
                a++;
            }

        }
    }
}
