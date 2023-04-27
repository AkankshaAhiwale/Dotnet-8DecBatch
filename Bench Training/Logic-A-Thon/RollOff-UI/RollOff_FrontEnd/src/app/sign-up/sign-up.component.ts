import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, FormGroup,Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '../shared/auth.service';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent {
  type:string ="password";
  isText:boolean=false;
  eyeIcon:string="fa-eye-slash";
  registerform!:FormGroup;
    
  constructor(
      private http: HttpClient,
      private auth:AuthService,
      private router:Router
  ){}

     ngOnInit(): void {
      this.registerform = new FormGroup({
        firstName: new FormControl('',[Validators.required,]),
        lastName: new FormControl('',[Validators.required,]),
        userName: new FormControl('',[Validators.required,]),
        email: new FormControl('',[Validators.required,]),
        password: new FormControl('',[Validators.required,]),
        role: new FormControl('',[Validators.required,]),
      });
      
  
    }

   
    submitForm(){  
      if(this.registerform.valid){
        this.auth.signUp(this.registerform.value)
        .subscribe({
          next:(res=>{
            alert(res.message)
            this.registerform.reset();
            this.router.navigate(['Login'])
          }),
          error:(err=>{
            alert(err.error.message)
          })
  
        })
      }

        
      }

      private validateAllFormFields(formGroup:FormGroup){
        Object.keys(formGroup.controls).forEach(field =>{
          const control =formGroup.get(field)
          if(control instanceof FormControl){
            control.markAsDirty({onlySelf:true});
          }else if(control instanceof FormGroup){
            this.validateAllFormFields(control)
          }
        })
      }
    

  hideShowPass(){
      this.isText = !this.isText;
      this.isText ? this.eyeIcon = "fa-eye" : this.eyeIcon ="fa-eye-slash";
      this.isText ? this.type= "text" : this.type="password";
  }
  get firstName():FormControl
       {
          return this.registerform.get("firstName") as FormControl;
       }
       get lastName():FormControl
       {
          return this.registerform.get("lastName") as FormControl;
       }
       get email():FormControl
       {
          return this.registerform.get("email") as FormControl;
       }
       get userName():FormControl
       {
          return this.registerform.get("userName") as FormControl;
       }
       get password():FormControl
       {
          return this.registerform.get("password") as FormControl;
       }
       get role():FormControl
       {
          return this.registerform.get("role") as FormControl;
       }
}
