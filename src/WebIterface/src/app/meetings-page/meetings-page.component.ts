import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-meetings-page',
  templateUrl: './meetings-page.component.html',
  styleUrls: ['./meetings-page.component.scss']
})
export class MeetingsPageComponent implements OnInit {
  meeting: string;
  meetings = ['first', 'second', 'third', '...']

  constructor(private route: ActivatedRoute) {
      this.route.params.subscribe(params => {
        this.meeting = params['meeting'];
      })
  }

  ngOnInit(): void {
  }

}
