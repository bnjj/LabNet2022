import { Component, OnInit ,Injectable} from '@angular/core';
import { ShipperService } from 'src/app/services/shipper.service';
import { Observable , Observer } from 'rxjs';
import { HttpResponse } from '@angular/common/http';
import { ShipperModelI ,ShipperToAddI} from 'src/app/models/shipper-model';
import { FormBuilder, FormControl, FormGroup,Validators, PatternValidator } from '@angular/forms';
import { identifierName, isNgTemplate } from '@angular/compiler';





@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css'],
})
export class DashboardComponent implements OnInit {

  formNewShipper! : FormGroup;
  formEditShipper! : FormGroup
  public shippers:ShipperModelI[] = [];
  public value:string ='true';

  public hideEditForm:boolean=true;
  public hideNewForm:boolean=true;
  public flag:Number=0;
  public btnWasPressed:boolean=false;

  constructor(private fb: FormBuilder,private _shipperService : ShipperService) { }

  ngOnInit(): void {
   
    this.formNewShipper = this.fb.group({
      nombre: new FormControl('',[Validators.required,Validators.maxLength(40)]),
      telefono: new FormControl('',[Validators.maxLength(24),Validators.pattern(/^-?(0|[1-9]\d*)?$/)])

    })
    this.formEditShipper = this.fb.group({
      nombre: new FormControl('',[Validators.required]),
      telefono: new FormControl('',[Validators.maxLength(24),Validators.pattern(/^-?(0|[1-9]\d*)?$/)])
    })
    this.getShippersLogic()
   
   
    
  }

  getShippersLogic(){
  
    this._shipperService.getShippers().subscribe({
        next:Response=> this.shippers=Response,
        error: err =>alert("No se pudo traer la lista desde el servidor")

    })
       
      

  }

  deleteShippersLogic(Id:Number)
  {
    
    this._shipperService.deleteShippers(Id).subscribe({
      complete:()=>
      {
        alert("El elemento fue eliminado de manera exitosa")
        this.getShippersLogic()
      },
      error:()=> 
      {
        alert("No se pudo eliminar este elemento.")
      
        this.getShippersLogic()
      }
    

    })
     
     
   
  }
  newShipperLogic(newShipper : ShipperToAddI)
  {  

    this._shipperService.addShippers(newShipper).subscribe({
      next:()=> 
      {
        this.getShippersLogic()
        this.hideNewForm=true
      },
      error:err=>
      {
        alert("Hubo un error enviado el nuevo shipper al servidor")
      },
      complete :()=>
      {
        alert("El nuevo shipper "+newShipper.CompanyName+" fue agregado con exito!")
      }
      
    })
   
    

  }



  editShippersLogic(editId:Number){
    var editShipper: ShipperModelI = {
      Id : editId,
      CompanyName : this.formEditShipper.get('nombre')?.value,
      Phone : this.formEditShipper.get('telefono')?.value
    }
     
    this._shipperService.editShippers(editShipper).subscribe(
      {
        complete:()=>    
        {
          alert("Esta edicion fue realizada con exito ")
          this.getShippersLogic()
          this.hideEditForm=true
        },
       error: err =>
       {
        alert("Esta edicion no fue recibida por el servidor")
       }
      })
     
  }



  NewFormSubmit()
  {
      var newShipper: ShipperToAddI = {
        CompanyName : this.formNewShipper.get('nombre')?.value,
        Phone : this.formNewShipper.get('telefono')?.value
      }
        this.newShipperLogic(newShipper)
  
  }





 ShowEditForm(Id:Number)
  {
     
      
    this.flag=Id
    this.hideEditForm=false
    this.formEditShipper.reset()
  }
 ShowNewForm(){
    this.hideNewForm=false
 }

 
  
}
      