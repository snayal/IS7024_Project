// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.



function myFunctionCrime() {
    // Declare variables
    var input, filter, table, tr, td, i, txtValue;
    input = document.getElementById("CrimeInput");
    filter = input.value.toUpperCase();
    table = document.getElementById("crimetable");
    tr = table.getElementsByTagName("tr");
    // Loop through all table rows, and hide those who don't match the search query
    for (i = 0; i < tr.length; i++) {
        alltags = tr[i].getElementsByTagName("td");
        isFound = false;
        for (j = 0; j < alltags.length; j++) {
            td = alltags[j];
            if (td) {
                txtValue = td.textContent || td.innerText;
                if (txtValue.toUpperCase().indexOf(filter) > -1) {
                    tr[i].style.display = "";
                    j = alltags.length;
                    isFound = true;
                }
                else {
                    tr[i].style.display = "none";
                }
            }

        }
    }
}

function myFunctionHealthcare() {
    // Declare variables
    var input, filter, table, tr, td, i, txtValue;
    input = document.getElementById("HealthcareInput");
    filter = input.value.toUpperCase();
    table = document.getElementById("healthcaretable");
    tr = table.getElementsByTagName("tr");
    // Loop through all table rows, and hide those who don't match the search query
    for (i = 0; i < tr.length; i++) {
        alltags = tr[i].getElementsByTagName("td");
        isFound = false;
        for (j = 0; j < alltags.length; j++) {
            td = alltags[j];
            if (td) {
                txtValue = td.textContent || td.innerText;
                if (txtValue.toUpperCase().indexOf(filter) > -1) {
                    tr[i].style.display = "";
                    j = alltags.length;
                    isFound = true;
                }
                else {
                    tr[i].style.display = "none";
                }
            }

        }
    }
}


function myFunctionProperty() {
    // Declare variables
    var input, filter, table, tr, td, i, txtValue;
    input = document.getElementById("PropertyInput");
    filter = input.value.toUpperCase();
    table = document.getElementById("Property");
    tr = table.getElementsByTagName("tr");
    // Loop through all table rows, and hide those who don't match the search query
    for (i = 0; i < tr.length; i++) {
        alltags = tr[i].getElementsByTagName("td");
        isFound = false;
        for (j = 0; j < alltags.length; j++) {
            td = alltags[j];
            if (td) {
                txtValue = td.textContent || td.innerText;
                if (txtValue.toUpperCase().indexOf(filter) > -1) {
                    tr[i].style.display = "";
                    j = alltags.length;
                    isFound = true;
                }
                else {
                    tr[i].style.display = "none";
                }
            }

        }
    }
}


var input = document.querySelectorAll('input');
for (i = 0; i < input.length; i++) {
    input[i].setAttribute('size', input[i].getAttribute('placeholder').length);
}


