import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { UserData } from '../models/UserData';
import { map } from 'rxjs/operators';

@Injectable()
export class AuthService {
  getusers() {
    throw new Error('Method not implemented.');
  }
  private _registerUrl = "https://localhost:44338/api/Login/register";
  private _loginUrl = "https://localhost:44338/api/Login/login";
  private _UserUrl = "https://localhost:44338/api/Login/User"
  getuser: any;

  constructor(private http: HttpClient, private _router:Router) { }

  registerUser(user: any) {
    return this.http.post<any>(this._registerUrl, user);
  }
  loginUser(user: any) {
    return this.http.post<any>(this._loginUrl, user);
  }
  loggedIn()
  {
    return !!localStorage.getItem('token')
  }
  logoutUser(){
    localStorage.removeItem('token');
    this._router.navigate(['/home']);
  }
  getUser() {
    return this.http.get<any>("https://localhost:44338/api/Login/User")
    
  }

}


function user<T>(_UserUrl: string, user: any): void {
  throw new Error('Function not implemented.');
}

