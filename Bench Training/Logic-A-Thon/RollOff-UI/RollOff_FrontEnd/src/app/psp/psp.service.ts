import { Injectable, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PSPComponent } from './psp.component';

@Injectable({
  providedIn: 'root'
})
export class PSPService{
  private baseUrl:string="http://localhost:14342/api/FeedBack";
  //public apiurl:string="http://localhost:14342/api/FeedBack/id";
  constructor(private httpClient:HttpClient) { 

  }

  
getRolloffRequest(){
return this.httpClient.get<any>(this.baseUrl);
}

// To get the request details using Id.
getId(requestId:any){
  let apiurl="http://localhost:14342/api/FeedBack/"+requestId;
  return this.httpClient.get<any>(apiurl)+requestId;
}
}
