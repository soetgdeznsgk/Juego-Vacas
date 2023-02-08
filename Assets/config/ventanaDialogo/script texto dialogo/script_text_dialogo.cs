using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script_text_dialogo : MonoBehaviour
{
    public Text textoEnIU;
    public float velocidadEscritura;
    private int indice;
    public bool escribiendo;
    public string[] dialogo;
    public ventanaDialogoConfig recuadroDialogo;
    public movimiento jugador;

    
    
    public IEnumerator EscribirEnPantalla()
    {
        escribiendo = true;
        
        if (dialogo[indice][0] == '-')
        {
            textoEnIU.color = Color.gray;
        }
        
        foreach (char letra in dialogo[indice].ToCharArray())
        {
            textoEnIU.text += letra;
            yield return new WaitForSeconds(velocidadEscritura);
        }
        escribiendo = false;
    }



    public void ReiniciarTexto()
    {
        textoEnIU.text = "...";
        indice = 0;
    }



    public void SiguienteDialogo()
    {
        if (indice < dialogo.Length - 1)
        {
            indice++;
            textoEnIU.text = "";
            StartCoroutine(EscribirEnPantalla());
        }
        else
        {
            // incluir cierre de la ventana
            jugador.interactua = false;    
            ReiniciarTexto();
        }
    }

}
