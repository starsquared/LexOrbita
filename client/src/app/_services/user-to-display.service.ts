import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { userToDisplay } from '../_models/userToDisplay';

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
    return this.http.get<userToDisplay>(this.baseUrl + 'users/' + username);
  }
}
