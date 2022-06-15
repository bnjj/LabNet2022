const form = document.getElementById('form');
const personName = document.getElementById('personname');
const username = document.getElementById('username');
const email = document.getElementById('email');
const password = document.getElementById('password');
const age = document.getElementById('age');


     

form.addEventListener('submit', e => {
   
	e.preventDefault();
 
	checkInputs();
  
});

function ResetForm()
{
    document.getElementById('form').reset(); 
}


function checkInputs() {
   
	//  remove the whitespace
    const personNameValue = personName.value.trim(); 
	const usernameValue = username.value.trim();
	const emailValue = email.value.trim();
	const passwordValue = password.value.trim();
    const ageValue= age.value.trim();

    CheckPersonName(personNameValue);
    CheckUsername(usernameValue);
    CheckEmail(emailValue);
    CheckPassword(passwordValue);
    CheckAge(ageValue);

}



function CheckPersonName(personNameValue){
    if(personNameValue === '') {
		setErrorFor(personName, 'Debe ingresar su nombre aqui');

	} 
     if (!isName(personNameValue)) {
		setErrorFor(personName, 'Su nombre solo puede tener letras');
    }
    else {
		setSuccessFor(personName);
	}
}



function CheckUsername(usernameValue)
{
    if(usernameValue === '') {
		setErrorFor(username, 'Debe ingresar su cuenta aqui');
	} else {
		setSuccessFor(username);
	}

}



function CheckEmail(emailValue)
{	
	if(emailValue === '') {
		setErrorFor(email, 'Debe ingresar su email aqui');
	} else if (!isEmail(emailValue)) {
		setErrorFor(email, 'Email no valido');
	} else {
		setSuccessFor(email);
	}

}


function CheckPassword(passwordValue)
{
	
	if(passwordValue === '') {
		setErrorFor(password, 'Debe ingresar su contraseña aqui');
	} 
   
    else {
		setSuccessFor(password);
	}
}

function CheckAge(ageValue)
{
    if(ageValue === ''){
		setErrorFor(age, 'Debe calcular  su edad ');
	}
    else 
    if (ageValue< 10) {
		setErrorFor(age, 'Desde  11 a 99 (presione enviar para recalcular)');
    }
    else {
		setSuccessFor(age);
	}
}


function setErrorFor(input, message) {
	const formControl = input.parentElement;
	const small = formControl.querySelector('small');
	formControl.className = 'form-control error';
	small.innerText = message;
}

function setSuccessFor(input) {
	const formControl = input.parentElement;
	formControl.className = 'form-control success';
}
	
function isEmail(email) {
	return /^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$/.test(email);
}
function isName(personName)
    {
        return /^[a-zA-Z]+$/.test(personName);
    }


function ageCalculator() {
    //recolectar valores 
    var userinput = document.getElementById("birthdate").value;
    var dob = new Date(userinput);
    
    // Hay input ?
    if(userinput==null || userinput==''){
      document.getElementById("result").innerHTML = "Selecciona una fecha por favor";  
      document.getElementById("age").value="";
      return false; 
    } 
    //ejecutar si el usuario ingreso fecha
    else {
    //Manejo Date
    var mdate = userinput.toString();
    var dobYear = parseInt(mdate.substring(0,4), 10);
    var dobMonth = parseInt(mdate.substring(5,7), 10);
    var dobDate = parseInt(mdate.substring(8,10), 10);
    
    //Fecha actual
    var today = new Date();
    
    var birthday = new Date(dobYear, dobMonth-1, dobDate);
    
    //Calcular diferencia fecha 
    var differenceInMillisecond = today.valueOf() - birthday.valueOf();

    //Convertir diferencia en ms a dias y años   
    var year_age = Math.floor(differenceInMillisecond / 31536000000);
    var day_age = Math.floor((differenceInMillisecond % 31536000000) / 86400000);

    //Fecha igual a hoy   
    if ((today.getMonth() == birthday.getMonth()) && (today.getDate() == birthday.getDate())) 
      {
            alert("Feliz Cumple!");
        }
        
     var month_age = Math.floor(day_age/30);        
     day_age = day_age % 30;
        

     
    //Fecha mayor a hoy 
     if (dob>today) {
        document.getElementById("age").value="";
        document.getElementById("result").innerHTML = ("Aun no naciste,por favor regresa a tu epoca viajero y no rompas este humilde formulario.");
      
      }
      else {
        document.getElementById("result").innerHTML = year_age + " años " + month_age + " meses " + day_age + " dias";
        document.getElementById("age").value =year_age;
      }
   }
}









