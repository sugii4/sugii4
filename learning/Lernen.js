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

//Aufgabe 5
function ermitteln() {
    zahl1 = parseInt(document.getElementById('zahl1').value);
    zahl2 = parseInt(document.getElementById('zahl2').value);
    minimal = Math.min(zahl1, zahl2);
    maximal = Math.max(zahl1, zahl2);
    document.getElementById('minimal').value = minimal;
    document.getElementById('maximal').value = maximal;
}

//Aufgabe 6
function sortieren() {
    zahl11 = parseInt(document.getElementById('zahl11').value);
    zahl22 = parseInt(document.getElementById('zahl22').value);
    zahl33 = parseInt(document.getElementById('zahl33').value);
    var sortiert = [zahl11, zahl22, zahl33];
    sortiert.sort();
    document.getElementById('sortiert').value = sortiert;
}