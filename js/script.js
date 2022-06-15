const form = document.getElementById('form');
const personName = document.getElementById('personname');
const username = document.getElementById('username');
const email = document.getElementById('email');
const password = document.getElementById('password');

     

form.addEventListener('submit', e => {
	e.preventDefault();
 
	checkInputs();
  
});




function checkInputs() {
	//  remove the whitespace
    const personNameValue = personName.value.trim(); 
	const usernameValue = username.value.trim();
	const emailValue = email.value.trim();
	const passwordValue = password.value.trim();

	if(personNameValue === '') {
		setErrorFor(personName, 'Debe ingresar su nombre aqui');
	} else {
		setSuccessFor(personName);
	}
	if(usernameValue === '') {
		setErrorFor(username, 'Debe ingresar su cuenta aqui');
	} else {
		setSuccessFor(username);
	}
	
	if(emailValue === '') {
		setErrorFor(email, 'Debe ingresar su email aqui');
	} else if (!isEmail(emailValue)) {
		setErrorFor(email, 'Email no valido');
	} else {
		setSuccessFor(email);
	}
	
	if(passwordValue === '') {
		setErrorFor(password, 'Debe ingresar su contraseña aqui');
	} else {
		setSuccessFor(password);
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
	return /^(.+)@(.+)$/.test(email);
}


function ageCalculator() {
    //collect input from HTML form and convert into date format
    var userinput = document.getElementById("birthdate").value;
    var dob = new Date(userinput);
    
    //check user provide input or not
    if(userinput==null || userinput==''){
      document.getElementById("message").innerHTML = "**Selecciona una fecha por favor";  
      return false; 
    } 
    
    //execute if user entered a date 
    else {
    //extract and collect only date from date-time string
    var mdate = userinput.toString();
    var dobYear = parseInt(mdate.substring(0,4), 10);
    var dobMonth = parseInt(mdate.substring(5,7), 10);
    var dobDate = parseInt(mdate.substring(8,10), 10);
    
    //get the current date from system
    var today = new Date();
    //date string after broking
    var birthday = new Date(dobYear, dobMonth-1, dobDate);
    
    //calculate the difference of dates
    var diffInMillisecond = today.valueOf() - birthday.valueOf();

    //convert the difference in milliseconds and store in day and year variable        
    var year_age = Math.floor(diffInMillisecond / 31536000000);
    var day_age = Math.floor((diffInMillisecond % 31536000000) / 86400000);

    //when birth date and month is same as today's date      
    if ((today.getMonth() == birthday.getMonth()) && (today.getDate() == birthday.getDate())) {
            alert("Feliz Cumple!");
        }
        
     var month_age = Math.floor(day_age/30);        
     day_age = day_age % 30;
        
     var tMnt= (month_age + (year_age*12));
     var tDays =(tMnt*30) + day_age;
     
    //DOB is greater than today?s date, generate an error: Invalid date  
     if (dob>today) {
        document.getElementById("result").innerHTML = ("Aun no naciste,por favor regresa a tu epoca viajero y no rompas este humilde formulario.");
      }
      else {
        document.getElementById("result").innerHTML = year_age + " años" + month_age + " meses " + day_age + " dias"
      }
   }
}









