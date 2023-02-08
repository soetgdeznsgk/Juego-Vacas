using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public Rigidbody2D cuerpo; 
    public animacionLink animacion;
    public ventanaDialogoConfig controlMenu;
    public float velocidadDinamica = 7f;
    float velocidadBase;

    public bool miraDer = false;
    public bool miraIzq = false;
    public bool miraArr = false;
    public bool miraAba = true;

    public bool interactua = false;

    public void SetDirUp(){
        miraAba = false;
        miraIzq = false;
        miraDer = false;
        miraArr = true;}

    public void SetDirDown(){
        miraAba = true;
        miraIzq = false;
        miraDer = false;
        miraArr = false;}

    public void SetDirLeft(){
        miraAba = false;
        miraIzq = true;
        miraDer = false;
        miraArr = false;}

    public void SetDirRight(){
        miraAba = false;
        miraIzq = false;
        miraDer = true;
        miraArr = false;}
    
    
    // Start is called before the first frame update
    void Start()
    {
        velocidadBase = velocidadDinamica;
    }


    // Update is called once per frame
    void Update()
    {       

            if (Input.GetKeyDown(KeyCode.LeftShift)) {
                velocidadDinamica *= 2;}

            if (Input.GetKeyUp(KeyCode.LeftShift)) {
                velocidadDinamica = velocidadBase;}



            if (Input.GetKeyDown(KeyCode.Z)) {
                interactua = true;}
        
            else if (Input.GetKeyDown(KeyCode.Escape)) {
                interactua = false;}        // DEBUG: todavía necesita estar asignado a un botón virtual dentro de la interfaz, y no a escape, que es accesible desde el gameplay libre


    
            if (Input.GetKey(KeyCode.UpArrow) && !controlMenu.menuAbierto) {
                SetDirUp();
                animacion.SeMueve();
                cuerpo.velocity = new Vector2(0f, velocidadDinamica);}

            else if (Input.GetKey(KeyCode.DownArrow) && !controlMenu.menuAbierto) {
                SetDirDown();
                animacion.SeMueve();
                cuerpo.velocity = new Vector2(0f, -1 * velocidadDinamica);}

            else if (Input.GetKey(KeyCode.LeftArrow) && !controlMenu.menuAbierto) {
                SetDirLeft();
                animacion.SeMueve();
                cuerpo.velocity = new Vector2(-1 * velocidadDinamica, 0f);}

            else if (Input.GetKey(KeyCode.RightArrow) && !controlMenu.menuAbierto) {
                SetDirRight();
                animacion.SeMueve();
                cuerpo.velocity = new Vector2(velocidadDinamica, 0f);}
                

            else{
                animacion.Quieto();
                cuerpo.velocity = new Vector2(0f, 0f);}


            animacion.Animar();
    }

}
