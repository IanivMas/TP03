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
    for (let i = 0; i < palabra.length; i++) {
        console.log(palabra[i]);
        console.log(guion[i]);
        if (palabra[i] == letra) {
            guiones[i] = letra;
            bool = true;
            console.log("letra correcta")
        }
    }
    if (bool == false) 
    {
        cantidadIntentos -= 1;
        console.log("letra equivocada");
    }
    intentos.innerText = "intentos: " + cantidadIntentos;
}