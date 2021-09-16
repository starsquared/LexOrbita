import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { userToDisplay } from '../_models/userToDisplay';

const httpOptions = {
  headers: new HttpHeaders({
    Authorization: 'Bearer ' + JSON.parse(localStorage.getItem('User'))?.token,
  }),
};

@Injectable({
  providedIn: 'root',
})
export class UserToDisplayService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getAllLawyers() {
    return this.http.get<userToDisplay[]>(this.baseUrl + 'users');
  }

  getSingleLawyer(username: string) {
    return this.http.get<userToDisplay[]>(
      this.baseUrl + 'users/' + username,
      httpOptions
    );
  }
}
