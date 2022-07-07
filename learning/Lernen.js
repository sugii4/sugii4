// Teil 1
//Aufgabe 1
document.getElementById("td1").innerHTML = "Hello World"; 
//Aufgabe 2
document.getElementById("td2").innerHTML = "Heute <br> ist <br> ist <br> ein <br> schöner <br> Tag"; 

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

//Aufgabe 7
var zahlen = [20, 35, 38, 40];
document.getElementById('share').innerHTML = zahlen;

function teileln() {
    for (var i = 0; i < zahlen.length; i++) {
        var e = zahlen[i];
            if (e % 2 == 0) {
            document.getElementById('ashare').innerHTML += e + ",";
            }
    }
    if (document.getElementById('ashare').innerHTML == "") {
        document.getElementById('ashare').innerHTML = "Es ist keine Zahl durch 2 teilbar"
    }
}

//Aufgabe 8
function quadratos() {
   quadro = parseInt(document.getElementById('quadro').value);
   quadratzahl = Math.sqrt(quadro);
   if (quadro % quadratzahl == 0) {
    document.getElementById('quadrot').value = quadratzahl;
   }
   if (document.getElementById('quadrot').value == "") {
    document.getElementById('quadrot').value = "Nein";
   }
}

//Aufgabe 9
function zeichenen() {
    eingabe = document.getElementById('symbol').value;
    ausgabe = isNaN(eingabe);
    if (ausgabe == true) {
        document.getElementById('ergebnis').value = "Buchstabe";
    }
    if (ausgabe == false) {
        document.getElementById('ergebnis').value = "Zahl";
    }
}

//Aufgabe 10
function alphabett() {
    elpha = document.getElementById('elpha').value;
    elphaAusgabe = isNaN(elpha);
        if(elphaAusgabe == true) {
            document.getElementById('alphe').value = "Buchstabe";
        }
        if (elphaAusgabe == false) {
            document.getElementById('alphe').value = "Zahl";
        }
    alphabet = parseInt(document.getElementById('elpha').value, 36) -9;
    document.getElementById('alphabet').value = alphabet;
        if (alphabet <= 0) {
            document.getElementById('alphabet').value = "kein Buchstabe im Alphabet";
        }
}

//Aufgabe 11
function zusammenenführen() {
    reihe1 = document.getElementById('reihe1').value;
    reihe2 = document.getElementById('reihe2').value;
    fullrow = reihe1 + reihe2;
    document.getElementById('fullrow').value = fullrow;
}

//Aufgabe 12
function stellenwert() {
    dreistellige = document.getElementById('dreistellige').value;
    document.getElementById('hundert').value = dreistellige[0];
    document.getElementById('zehn').value = dreistellige[1];
    document.getElementById('eins').value = dreistellige[2];
}

// Teil 2
//Aufgabe 1
