// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
var CurrentTurn = "X";
 document.getElementById("turn").innerText = "It is Player" + CurrentTurn + "'s turn";

var square = document.getElementsByClassName("square");
for (var i = 0; i < square; i++)
{
    square[i].addEventListener('click', onclick)

}
function onclick() {
    event.preventDefault();
    if (!event.target.innerText) { }
    event.target.innerText = CurrentTurn;
    nextTurn();
}
}
function nextTurn() {
    if (CurrentTurn === "X") {

        CurrentTurn = "O";
    }
    else {

        CurrentTurn = "X";
    }



}