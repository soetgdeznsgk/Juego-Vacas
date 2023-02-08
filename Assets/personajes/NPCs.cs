using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCs : MonoBehaviour
{
    [HideInInspector] public Contador cuenta; 
    [HideInInspector] public movimiento jugador;
    public Rigidbody2D objeto;
    [HideInInspector] public script_text_dialogo scriptTextoVentanaDeDialogo;
    public Color colorTexto;
    public Animator animacion;
   
    public string[] discursoDelPersonaje;
    [HideInInspector] public bool haInteractuado = false;
    private bool enRango = false;



    private void OnCollisionEnter2D(Collision2D other) 
    {
        enRango = true;
    }



    public virtual void OnCollisionStay2D(Collision2D other) 
    {
        //Debug.Log("hay colisión!");
        if (other.collider.CompareTag("Player"))
        {
            jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<movimiento>();
            Interaccion();
        }
    }



    private void OnCollisionExit2D(Collision2D other)
    {
        enRango = false;
    }



    public virtual void Interaccion()
    {
        if(jugador.interactua)
        {
            jugador.controlMenu.ElevarVentanaDialogo(); 
            //Debug.Log("se interactúa");

            if (!haInteractuado)
            {    
                haInteractuado = true;
                cuenta.ContarConocido();
                //Debug.Log("se ha conocido");
            }
        }
        else
        {
            //Debug.Log("se ha activado el cierre");
            jugador.controlMenu.CerrarVentanaDialogo();
        }
        
        scriptTextoVentanaDeDialogo = GameObject.FindGameObjectWithTag("texto de dialogo").GetComponent<script_text_dialogo>();        
        scriptTextoVentanaDeDialogo.dialogo = discursoDelPersonaje;

        if(Input.GetKeyDown(KeyCode.E) && scriptTextoVentanaDeDialogo.escribiendo == false && jugador.controlMenu.menuAbierto)
        {
            scriptTextoVentanaDeDialogo.textoEnIU.color = colorTexto;   // debug: necesito alternar entre 2 colores de texto, uno para el dialogo del personaje y otro para el jugador
            scriptTextoVentanaDeDialogo.SiguienteDialogo();
        }
    }



    void Start()
    {
        animacion = GetComponent<Animator>();
        cuenta = GameObject.FindGameObjectWithTag("contador IU").GetComponent<Contador>();
    }



    void Update() // 
    {
        if (enRango)
        {
            Interaccion();
        }
    }
    
}
