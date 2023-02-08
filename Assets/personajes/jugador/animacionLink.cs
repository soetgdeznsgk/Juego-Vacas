using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacionLink : MonoBehaviour
{
    public movimiento controladorMovimiento;
    public Animator anim;
    public Rigidbody2D cuerpo;
    public bool seMueve = false;

    public void Quieto(){
        seMueve = false;}
    
    public void SeMueve(){
        seMueve = true;}

    public void Animar(){
        if (!seMueve) {
            if (controladorMovimiento.miraAba) {
                anim.Play("down_idle");}
            else if (controladorMovimiento.miraArr) {
                anim.Play("up_idle");}
            else if (controladorMovimiento.miraDer) {
                anim.Play("right_idle");}
            else if (controladorMovimiento.miraIzq) {
                anim.Play("left_idle");}}

        else if (seMueve) {
            //Debug.Log("semueveo");
            if (controladorMovimiento.miraAba) {
                anim.Play("down_walk");}
            else if (controladorMovimiento.miraArr) {
                anim.Play("up_walk");}
            else if (controladorMovimiento.miraDer) {
                anim.Play("right_walk");}
            else if (controladorMovimiento.miraIzq) {
                anim.Play("left_walk");}}
        }

}
