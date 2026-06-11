// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let cantidadIntentos = 10;
let intentos = document.getElementById("intentos");
intentos.innerText = "intentos: " + cantidadIntentos;
function arriesgarLetra() {
    let palabra = document.getElementById("palabra").value;
    let letra = document.getElementById("letra").value;
    let guiones = document.getElementById("guiones");
    let bool = false;
    let nuevoTexto = "";
    for (let i = 0; i < palabra.length; i++) {
       
        if (palabra[i] == letra) {
            nuevoTexto += letra;
            bool = true;
           
        }
        else
        {
             nuevoTexto += guiones.innerText[i];
        }
    }
     guiones.innerText = nuevoTexto;
    if (bool == false) 
    {
        cantidadIntentos -= 1;
        
    }
    intentos.innerText = "intentos: " + cantidadIntentos;
}