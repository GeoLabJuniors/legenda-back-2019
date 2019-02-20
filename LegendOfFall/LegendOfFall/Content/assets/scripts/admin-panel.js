var logOffButton = document.getElementsByClassName("log-out")[0];
logOffButton.addEventListener("click", function () {
    var form = document.getElementById("log-out-form");
    form.submit();
})

