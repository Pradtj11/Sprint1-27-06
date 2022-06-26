import { Component, OnInit } from '@angular/core';
import { UserData } from '../models/UserData';
import { AuthService } from '../services/auth.service';


@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  constructor(private _auth: AuthService) { }

  users: Array<UserData> = new Array<UserData>();
  ngOnInit(): void {

    this._auth.getUser().subscribe(res => this.users = res, err => console.log(err))
  }

}