import { Component, OnInit } from '@angular/core';
import { PSPService } from '../psp/psp.service';
import { FormComponent } from '../form/form.component';
import { ActivatedRoute } from '@angular/router';
@Component({
  selector: 'app-request-details',
  templateUrl: './request-details.component.html',
  styleUrls: ['./request-details.component.css']
})
export class RequestDetailsComponent implements OnInit{
  constructor(public pspService:PSPService,
    private readonly route:ActivatedRoute){

  }
    requestId:string|null|undefined;
    //globalGroupId:string|null|undefined;
    rollOffRequest:any=[{
    globalGroupId:0,
    name:'',
    practice:'',
    /*performanceIssue:'',
    technicalSkill:'',
    localGrade:'',
    rollOffEndDate:new Date,
    resigned:'',
    communication:'',
    primarySkill:'',
    reasonForRollOff:'',
    underProbation:'',
    roleCompetencies:'',
    projectCode:'',
    otherReasons:'',
    longLeave:'',
    remarks:'',
    projectName:'',
    thisReleaseNeedsBackfillIsBackfilled:'',
    leaveType:'',
    relevantExperienceYears:'',*/
}]
ngOnInit(): void {
  this.route.paramMap.subscribe(
    (params)=>{
      this.requestId=params.get('id');
      if(this.requestId){
        this.pspService.getId(this.requestId)
        .subscribe(
          (successResponse: any)=>{
            this.rollOffRequest=successResponse;
            console.log(this.rollOffRequest);
          }
        );
      }
    }
 );
 console.log(this.rollOffRequest.value);
}
}
