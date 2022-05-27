using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QubeGenerator : MonoBehaviour
{
    [SerializeField] private GameObject qubePrefab;
    [SerializeField] private int layers = 3;
    [SerializeField] private float qubePadding = 0.5f;

    private void Start()
    {
        StartCoroutine(GenerateQube(layers));
    }

    private IEnumerator GenerateQube(int size)
    {
        float qubeSize = qubePrefab.GetComponent<BoxCollider>().size.x + qubePadding;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                for (int k = 0; k < size; k++)
                {
                    Vector3 pos = new Vector3(qubePadding + k * qubeSize, qubePadding + j * qubeSize, qubePadding + i * qubeSize);
                    var go = Instantiate(qubePrefab, pos, Quaternion.identity, transform);
                    yield return new WaitForEndOfFrame();
                }
            }
        }
    }
}