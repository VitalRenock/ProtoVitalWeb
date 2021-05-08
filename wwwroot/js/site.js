// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function TestJava() {
    
    var test = document.getElementById("maBalise");
    if (test != null) {
        test.innerHTML = "<p><strong>Hello Java</strong></p>";
    }
    else {
        console.log("TestJava");
    }
}
