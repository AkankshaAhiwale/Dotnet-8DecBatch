import { Component, OnInit } from '@angular/core';
import { PSPService } from './psp.service';

@Component({
  selector: 'app-psp',
  templateUrl: './psp.component.html',
  styleUrls: ['./psp.component.css']
})
export class PSPComponent implements OnInit {
  flag:any[];
  feedbackData:any[];
  page:number=1;
  count:number=0;
  tableSize: number=6;
  tableSizes:any[10];
  constructor(private pspService:PSPService){
  }
  
  
  ngOnInit(): void {
    this.pspService.getRolloffRequest().subscribe(result=>{this.feedbackData=result;})
  }

  onTableDataChange(event: any) {
    this.page = event;
    this.pspService.getRolloffRequest().subscribe(result=>{this.feedbackData=result;})
  }
  onTableSizeChange(event: any): void {
    this.tableSize = event.target.value;
    this.page = 1;
    this.pspService.getRolloffRequest().subscribe(result=>{this.feedbackData=result;})
  }

  //To get the total count of records of requested rolloff
  public getRowsValue(flag: null) {
    if (flag === null) {
      return this.feedbackData.length;
    } else {
      return this.feedbackData.filter(i => (i.state == flag)).length;
    }
  }

}
