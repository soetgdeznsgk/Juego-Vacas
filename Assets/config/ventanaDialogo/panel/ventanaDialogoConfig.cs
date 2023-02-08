using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ventanaDialogoConfig : MonoBehaviour
{
        public bool menuAbierto;
        public bool opcion; // para incluir las opciones de dialogo
        private Vector3 posicionOriginal;

    void Start()
    {
        posicionOriginal = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    public void ElevarVentanaDialogo()
    {
        if (!menuAbierto)
        {
            LeanTween.moveY(gameObject, 100f, 0.5f);
            menuAbierto = true;
        }
    }

    public void CerrarVentanaDialogo()
    {
        if (menuAbierto)
        {
            LeanTween.moveY(gameObject, posicionOriginal.y, 0.3f);
            menuAbierto = false; 
        }
    }

}
