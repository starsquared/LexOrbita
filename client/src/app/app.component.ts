import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { User } from './_models/user';
import { AccountService } from './_services/account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'LexOrbita';
  users: any;

  constructor(private accountService: AccountService) {}

  ngOnInit() {
    // this.getAllLawyerUsers();
    this.setCurrentUser();
  }

  setCurrentUser() {
    const user: User = JSON.parse(localStorage.getItem('user'));
    this.accountService.setCurentUser(user);
  }

  // getAllLawyerUsers() {
  //   this.http.get('https://localhost:5001/api/users').subscribe(
  //     (response) => {
  //       this.users = response;
  //     },
  //     (error) => {
  //       console.log(error);
  //     }
  //   );
  // }
}
