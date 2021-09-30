import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import {
  NgxGalleryAnimation,
  NgxGalleryImage,
  NgxGalleryOptions,
} from '@kolkov/ngx-gallery';
import { userToDisplay } from 'src/app/_models/userToDisplay';
import { UserToDisplayService } from 'src/app/_services/user-to-display.service';

@Component({
  selector: 'app-lawyer-detail',
  templateUrl: './lawyer-detail.component.html',
  styleUrls: ['./lawyer-detail.component.css'],
})
export class LawyerDetailComponent implements OnInit {
  lawyer: userToDisplay;
  galleryOptions: NgxGalleryOptions[];
  galleryImages: NgxGalleryImage[];

  constructor(
    private userToDisplayService: UserToDisplayService,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.loadLawyer();

    this.galleryOptions = [
      {
        width: '500px',
        height: '500px',
        imagePercent: 100,
        thumbnailsColumns: 4,
        imageAnimation: NgxGalleryAnimation.Slide,
        preview: false,
      },
    ];
  }

  getImages(): NgxGalleryImage[] {
    const imageUrls = [];
    for (const photo of this.lawyer.photos) {
      imageUrls.push({
        small: photo?.url,
        medium: photo?.url,
        big: photo?.url,
      });
    }
    return imageUrls;
  }

  loadLawyer() {
    this.userToDisplayService
      .getSingleLawyer(this.route.snapshot.paramMap.get('username'))
      .subscribe((lawyer) => {
        this.lawyer = lawyer;
        this.galleryImages = this.getImages();
      });
  }
}
