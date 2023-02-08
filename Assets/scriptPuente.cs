using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPuente : MonoBehaviour
{
    public bool puenteActivo;
    public EdgeCollider2D costaAmerica;



    [ContextMenu("Hundir puente")] // ésto es un trigger que tendrá la fogata, sin embargo mientras lo implemento, se hará desde el menú
    public void HunidrPuente()
    {
        costaAmerica.enabled = true;
        gameObject.SetActive(puenteActivo);
    }



    void Start()
    {
        costaAmerica.enabled = false;
    }
}
