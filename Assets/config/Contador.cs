using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public int contadorDeConocidos;
    public Text numeroEnIU;

    [ContextMenu("Aumentar")]

    public void ContarConocido() {
        contadorDeConocidos += 1;
        numeroEnIU.text = contadorDeConocidos.ToString() + " / ?";
    }
    
}
