import { Component, Input, OnInit } from '@angular/core';
import { userToDisplay } from 'src/app/_models/userToDisplay';

@Component({
  selector: 'app-lawyer-card',
  templateUrl: './lawyer-card.component.html',
  styleUrls: ['./lawyer-card.component.css'],
})
export class LawyerCardComponent implements OnInit {
  @Input() lawyer: userToDisplay;

  constructor() {}

  ngOnInit(): void {}
}
