console.log('starting javascript')

function ValidateEmail() {
    var inputText = document.forms["email"]["emailText"].value;
    
    console.log('starting ValidateEmail using' + inputText)
    var regEx = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    if (regEx.test(inputText) ) {
        alert("Your email address has been accepted");
        document.form1.emailText.focus();
        return true;
    }
    else {
        alert("You have entered an invalid email address!");
        document.form1.emailText.focus();
        return false;
    }
}