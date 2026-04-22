using UnityEngine;

public class EX03 : MonoBehaviour
{
    [SerializeField] float[] notas = new float[8];
    void Start()
    {
        foreach (float nota in notas)
        {
            if (nota >= 6)
            {
                print(nota + ", alune foi aprovade");
            }
            else
            {
                print(nota + ", alune foi reprovade");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
