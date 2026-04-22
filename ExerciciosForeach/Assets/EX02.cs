using UnityEngine;

public class EX02 : MonoBehaviour
{
    [SerializeField] string[] nomes = new string[5];
    void Start()
    {
        foreach (string nome in nomes)
        {
            nome.ToUpper();
            print(nome);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
