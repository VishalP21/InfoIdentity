
    const passwordField = document.getElementById("password");
    const togglePassword = document.querySelector(".password-toggle-icon i");

    togglePassword.addEventListener("click", function () {
        if (passwordField.type === "password") {
        passwordField.type = "text";
            togglePassword.classList.remove("ri-eye-off-line");
            togglePassword.classList.add("ri-eye-line");
        } else {
        passwordField.type = "password";
            togglePassword.classList.remove("ri-eye-line");
            togglePassword.classList.add("ri-eye-off-line");
        }
    });
