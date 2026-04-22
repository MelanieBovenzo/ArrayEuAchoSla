using UnityEngine;

public class EX04 : MonoBehaviour
{
    int multiplosDe3;
    int[] numeros = new int[20];
    void Start()
    {
        int i = 0;

        while (i <= numeros.Length)
        {
            numeros[i] = i+1;
            if (numeros[i] % 3 == 0)
            {
                multiplosDe3++;
            }
            print(numeros[i]);
            i++;
        }
        print(multiplosDe3 + " multiples of tres");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
