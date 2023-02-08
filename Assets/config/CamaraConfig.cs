using UnityEngine;

public class CamaraConfig : MonoBehaviour
{
    public GameObject jugador;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    void Update()
    {
         transform.position = new Vector3(jugador.transform.position.x, jugador.transform.position.y, transform.position.z);
    }

}
