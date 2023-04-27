import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class FormService {

  constructor(private http:HttpClient) { }
  
  createUser(createResource:any){
    console.log(createResource);
    return this.http.post('http://localhost:14342/api/FeedBack',createResource);
  }
}
