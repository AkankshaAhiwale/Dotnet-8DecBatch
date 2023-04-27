import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { FormService } from './form.service';
import Swal from 'sweetalert2';
import { RollOffFormComponent } from '../RollOffDetails/roll-off-form/roll-off-form.component';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent {
  globalGroupId:number;
  Name:string='';
  practice:string='';
  performanceIssue:string='';
  technicalSkill:string='';
    localGrade:string='';
    rollOffEndDate:Date;
    resigned:string='';
    communication:string='';
    primarySkill:string='';
    reasonForRollOff:string='';
    underProbation:string='';
    roleCompetencies:string='';
    projectCode:string='';
    otherReasons:string='';
    longLeave:string='';
    remarks:string='';
    projectName:string='';
    thisReleaseNeedsBackfillIsBackfilled:string='';
    leaveType:string='';
    relevantExperienceYears:string='';
    addEmp!:FormGroup;
  constructor(public form:FormService){
    
  }

  
  ngOnInit(): void{
    this.addEmp=new FormGroup({
      globalGroupId:new FormControl(),
      Name:new FormControl(''),
      practice:new FormControl(''),
      performanceIssue:new FormControl(''),
      technicalSkill:new FormControl(''),
      localGrade:new FormControl(''),
      rollOffEndDate:new FormControl(''),
      resigned:new FormControl(''),
      communication:new FormControl(''),
      primarySkill:new FormControl(''),
      reasonForRollOff:new FormControl(''),
      underProbation:new FormControl(''),
      roleCompetencies:new FormControl(''),
      projectCode:new FormControl(''),
      otherReasons:new FormControl(''),
      longLeave:new FormControl(''),
      remarks:new FormControl(''),
      projectName:new FormControl(''),
      thisReleaseNeedsBackfillIsBackfilled:new FormControl(''),
      leaveType:new FormControl(''),
      relevantExperienceYears:new FormControl('')
    }
    );
  }
  SaveData(){
    
    this.form.createUser(this.addEmp.value).subscribe(result=>{
      console.log(result);
      this.addEmp.reset();
      
    })
    //console.log(this.addEmp.value);
    }
    
    alertWithSuccess(){
      Swal.fire({text:'Feedback Submitted Successfully',
      icon:'success'
    });
    }
    
    
    
}
