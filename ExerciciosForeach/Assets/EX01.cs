using UnityEngine;

public class EX01 : MonoBehaviour
{
    int[] numeros = new int[10];
    int[] pares = new int[5] {0, 2, 4, 6, 8};
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i=0; i<numeros.Length; i += 2) {
            numeros[i] = pares[Random.Range(0, 5)];
            print(numeros[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
