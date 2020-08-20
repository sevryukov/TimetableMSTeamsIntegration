import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-teams-page',
  templateUrl: './teams-page.component.html',
  styleUrls: ['./teams-page.component.scss']
})
export class TeamsPageComponent implements OnInit {

  teams = ['first', 'second', 'third', '...']

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  goTeam(){
    this.router.navigate(['/meeting'])
  }

}
