// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

var input = document.querySelectorAll('input');
for (i = 0; i < input.length; i++) {
    input[i].setAttribute('size', input[i].getAttribute('placeholder').length);
}


