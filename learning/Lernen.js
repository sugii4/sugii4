//Aufgabe 1
document.getElementById("tr1").innerHTML = "Hello World"; 
//Aufgabe 2
document.getElementById("tr2").innerHTML = "Heute <br> ist <br> ist <br> ein <br> schöner <br> Tag"; 

//Aufgabe 3
function berechnen() { 
    eingabe1 = parseInt(document.getElementById('eingabe1').value);
    eingabe2 = parseInt(document.getElementById('eingabe2').value);
    ausgabe = eingabe1 + eingabe2;
    document.getElementById('ausgabe').value = ausgabe;
} 

//Aufgabe 4
function ausrechnen() {
    länge = parseInt(document.getElementById('länge').value);
    würfel = länge ** 3;
    quadrat = länge * länge;
    document.getElementById('würfel').value = würfel;
    document.getElementById('quadrat').value = quadrat;
}