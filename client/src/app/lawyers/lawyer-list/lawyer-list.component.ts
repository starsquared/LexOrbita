import { Component, OnInit } from '@angular/core';
import { userToDisplay } from 'src/app/_models/userToDisplay';
import { UserToDisplayService } from 'src/app/_services/user-to-display.service';

@Component({
  selector: 'app-lawyer-list',
  templateUrl: './lawyer-list.component.html',
  styleUrls: ['./lawyer-list.component.css'],
})
export class LawyerListComponent implements OnInit {
  lawyers: userToDisplay[];

  constructor(private userToDisplayService: UserToDisplayService) {}

  ngOnInit(): void {
    this.loadLawyers();
  }

  loadLawyers() {
    this.userToDisplayService.getAllLawyers().subscribe((lawyers) => {
      this.lawyers = lawyers;
    });
  }
}
