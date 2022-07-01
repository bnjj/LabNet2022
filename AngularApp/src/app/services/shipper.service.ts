import { Injectable } from "@angular/core"
import { HttpClient ,HttpHeaders } from "@angular/common/http"
import { Observable } from "rxjs"

import { ShipperModelI, ShipperToAddI } from "../models/shipper-model"




const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type':  'application/json'
  })
};

@Injectable({
    providedIn: 'root'
  })


  export class ShipperService {

    url :string = 'https://localhost:44333/Api/Shippers'
    constructor(private http : HttpClient)  { }

    
    getShippers():Observable<ShipperModelI[]>{
        return this.http.get<ShipperModelI[]>(this.url,)
    }
    
    deleteShippers(id :Number):Observable<ShipperModelI>{
      return this.http.delete<ShipperModelI>(this.url+'?Id='+id)
    }
  
    addShippers(newShipper:ShipperToAddI):Observable<any>{
 
        return this.http.post<ShipperModelI>(this.url,newShipper,httpOptions)
    }
  
   editShippers(editShipper:ShipperModelI):Observable<any>
   {
        return this.http.put<ShipperModelI>(this.url,editShipper,httpOptions)
   }
  
  
    
    
  }